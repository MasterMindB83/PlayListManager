using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlayListManager
{
    public partial class Form1 : Form
    {
        public String sFromPath,sFileLists, sPlaylist1,sPlaylist2;
        public int iCommandType = 1;
        List<String> lFiles=new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_from_Click(object sender, EventArgs e)
        {
            String sFilePath;
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.DefaultExt = "m3u";
            FD.Filter = "PlayLists (*.m3u)|*.m3u|All files (*.*)|*.*";
            FD.InitialDirectory = Environment.CurrentDirectory;
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_from.Text= FD.FileName;
                sFromPath = textBox_from.Text.Substring(0,textBox_from.Text.LastIndexOf("\\"));

                sPlaylist1 = null;
                sFileLists = null;
                try
                {
                    lFiles.Clear();
                }
                catch { }

                System.IO.StreamReader reader = new System.IO.StreamReader(textBox_from.Text);
                String line=null;
                int rbr = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (sPlaylist1 != null)
                        sPlaylist1 += "\n";
                    sPlaylist1 += line;

                    if (rbr != 0 && (rbr / 2) * 2 == rbr)
                    {
                        if (sFileLists != null)
                            sFileLists += "\n";

                        if(line.Substring(0,1)!="\\")
                            sFilePath = sFromPath + "\\";//sFileLists += sFromPath + "\\";
                        else
                            sFilePath = sFromPath.Substring(0, 2);//sFileLists += sFromPath.Substring(0,2);//c:4

                        sFilePath += line;

                        sFileLists += sFilePath;
                        lFiles.Add(sFilePath);
                    }

                    rbr++;
                }
            }
            lista_pesama.Text = sPlaylist1;
        }

        private void btn_to_Click(object sender, EventArgs e)
        {
            //string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            //folderBrowserDialog1.SelectedPath= Environment.CurrentDirectory;//Directory.GetCurrentDirectory();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_to.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            String sFileName,sTargetPath,sPlaylistName;
            sPlaylistName = textBox_from.Text.Substring(textBox_from.Text.LastIndexOf("\\") + 1,
                                                      textBox_from.Text.LastIndexOf(".") - textBox_from.Text.LastIndexOf("\\") - 1
                                                      );
            sTargetPath = textBox_to.Text;

            if(chk_create_subfolder.Checked)
              sTargetPath += "\\" + sPlaylistName;

                

            if (iCommandType == 1)// Copy
            {
                if (!System.IO.Directory.Exists(sTargetPath))
                {
                    System.IO.Directory.CreateDirectory(sTargetPath);
                }

                foreach (var c in lFiles)
                {
                    sFileName = c.ToString().Substring(c.ToString().LastIndexOf("\\") + 1);
                    try
                    {
                        System.IO.File.Copy(c.ToString(),
                                            sTargetPath + "\\" + sFileName);
                    }
                    catch { }
                }

                createPlaylist(sPlaylistName);
            }
            if (iCommandType == 2)// Move
            {
                if (!System.IO.Directory.Exists(sTargetPath))
                {
                    System.IO.Directory.CreateDirectory(sTargetPath);
                }

                foreach (var c in lFiles)
                {
                    sFileName = c.ToString().Substring(c.ToString().LastIndexOf("\\") + 1);
                    try
                    {
                        System.IO.File.Move(c.ToString(),
                                            sTargetPath + "\\" + sFileName);
                    }
                    catch { }
                }

                createPlaylist(sPlaylistName);
            }
            if (iCommandType == 3)// Delete
            {
                foreach (var c in lFiles)
                {
                    sFileName = c.ToString().Substring(c.ToString().LastIndexOf("\\") + 1);
                    try
                    {
                        System.IO.File.Delete(c.ToString());
                    }
                    catch { }
                }
            }

        }
        public void createPlaylist(String sPlaylistName)
        {
            String sLine="",sTargetPath,sFolderName;
            int nPos=0;

            if (chk_create_subfolder.Checked)
            {
                sTargetPath = textBox_to.Text;
                sFolderName = sPlaylistName;
            }
            else
            {
                sTargetPath = textBox_to.Text.Substring(0,textBox_to.Text.LastIndexOf("\\"));
                sFolderName = textBox_to.Text.Substring(textBox_to.Text.LastIndexOf("\\")+1);
            }

            if (chk_create_playlist.Checked)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(sTargetPath + "\\" + sPlaylistName + ".m3u",false);
                sPlaylist2 = "";
                ReadLine(ref nPos,ref sLine);
                writer.WriteLine(sLine);
                sPlaylist2 = sLine;
                int nRbr=1;
                while (nPos < lista_pesama.Text.Length)
                {
                    ReadLine(ref nPos, ref sLine);

                    if ((nRbr / 2) * 2 == nRbr)
                    {
                        sPlaylist2 += sFolderName + "\\" + sLine.Substring(sLine.LastIndexOf("\\") + 1) + "\n";
                        sLine = sFolderName + "\\" + sLine.Substring(sLine.LastIndexOf("\\") + 1);
                    }
                    else
                    {
                        sPlaylist2 += sLine + "\n";
                    }

                    writer.WriteLine(sLine);
                    nRbr++;
                }
                writer.Close();

                //System.IO.File.CreateText(sTargetPath + "\\" + sPlaylistName + ".m3u");
            }
        
        }
        public void ReadLine(ref int nPos1,ref String sLine)
        {
            int nPos2;
            sLine = "";
            if (nPos1 == lista_pesama.Text.Length)
                return;
            nPos2=lista_pesama.Text.IndexOf("\n", nPos1);

            if (nPos2 < 0)
                nPos2 = lista_pesama.Text.Length;

            nPos2++;

            sLine = lista_pesama.Text.Substring(nPos1, nPos2 - nPos1 - 1);
            nPos1=nPos2;

        }
        private void btn_list1_Click(object sender, EventArgs e)
        {

            lista_pesama.Text = sPlaylist1;
        }

        private void btn_files_Click(object sender, EventArgs e)
        {
            lista_pesama.Text = sFileLists;

        }

        private void btn_list2_Click(object sender, EventArgs e)
        {
            lista_pesama.Text = sPlaylist2;

        }


        private void rad_copy_CheckedChanged(object sender, EventArgs e)
        {
            iCommandType = 1;
        }

        private void rad_move_CheckedChanged(object sender, EventArgs e)
        {

            iCommandType = 2;
        }

        private void rad_delete_CheckedChanged(object sender, EventArgs e)
        {

            iCommandType = 3;
        }

        private void chk_create_playlist_CheckedChanged(object sender, EventArgs e)
        {
            String sPlaylistName = textBox_from.Text.Substring(textBox_from.Text.LastIndexOf("\\") + 1,
                                                      textBox_from.Text.LastIndexOf(".") - textBox_from.Text.LastIndexOf("\\") - 1
                                                      );
            createPlaylist(sPlaylistName);
        }



        

    }
        
}
