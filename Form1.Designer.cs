namespace PlayListManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_from = new System.Windows.Forms.Button();
            this.btn_to = new System.Windows.Forms.Button();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.rad_copy = new System.Windows.Forms.RadioButton();
            this.rad_move = new System.Windows.Forms.RadioButton();
            this.rad_delete = new System.Windows.Forms.RadioButton();
            this.lista_pesama = new System.Windows.Forms.RichTextBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.btn_list1 = new System.Windows.Forms.Button();
            this.btn_files1 = new System.Windows.Forms.Button();
            this.chk_create_subfolder = new System.Windows.Forms.CheckBox();
            this.chk_create_playlist = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_from
            // 
            this.btn_from.BackColor = System.Drawing.Color.Black;
            this.btn_from.ForeColor = System.Drawing.Color.White;
            this.btn_from.Location = new System.Drawing.Point(231, 13);
            this.btn_from.Name = "btn_from";
            this.btn_from.Size = new System.Drawing.Size(38, 23);
            this.btn_from.TabIndex = 0;
            this.btn_from.Text = "From";
            this.btn_from.UseVisualStyleBackColor = false;
            this.btn_from.Click += new System.EventHandler(this.btn_from_Click);
            // 
            // btn_to
            // 
            this.btn_to.BackColor = System.Drawing.Color.Black;
            this.btn_to.ForeColor = System.Drawing.Color.White;
            this.btn_to.Location = new System.Drawing.Point(231, 42);
            this.btn_to.Name = "btn_to";
            this.btn_to.Size = new System.Drawing.Size(38, 23);
            this.btn_to.TabIndex = 1;
            this.btn_to.Text = "To";
            this.btn_to.UseVisualStyleBackColor = false;
            this.btn_to.Click += new System.EventHandler(this.btn_to_Click);
            // 
            // textBox_from
            // 
            this.textBox_from.AllowDrop = true;
            this.textBox_from.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_from.Location = new System.Drawing.Point(5, 13);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(221, 20);
            this.textBox_from.TabIndex = 2;
            // 
            // textBox_to
            // 
            this.textBox_to.AllowDrop = true;
            this.textBox_to.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_to.Location = new System.Drawing.Point(5, 44);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(221, 20);
            this.textBox_to.TabIndex = 3;
            // 
            // rad_copy
            // 
            this.rad_copy.AutoSize = true;
            this.rad_copy.Checked = true;
            this.rad_copy.Location = new System.Drawing.Point(276, 2);
            this.rad_copy.Name = "rad_copy";
            this.rad_copy.Size = new System.Drawing.Size(49, 17);
            this.rad_copy.TabIndex = 4;
            this.rad_copy.TabStop = true;
            this.rad_copy.Text = "Copy";
            this.rad_copy.UseVisualStyleBackColor = true;
            this.rad_copy.CheckedChanged += new System.EventHandler(this.rad_copy_CheckedChanged);
            // 
            // rad_move
            // 
            this.rad_move.AutoSize = true;
            this.rad_move.Location = new System.Drawing.Point(276, 25);
            this.rad_move.Name = "rad_move";
            this.rad_move.Size = new System.Drawing.Size(52, 17);
            this.rad_move.TabIndex = 5;
            this.rad_move.Text = "Move";
            this.rad_move.UseVisualStyleBackColor = true;
            this.rad_move.CheckedChanged += new System.EventHandler(this.rad_move_CheckedChanged);
            // 
            // rad_delete
            // 
            this.rad_delete.AutoSize = true;
            this.rad_delete.Location = new System.Drawing.Point(276, 48);
            this.rad_delete.Name = "rad_delete";
            this.rad_delete.Size = new System.Drawing.Size(56, 17);
            this.rad_delete.TabIndex = 6;
            this.rad_delete.Text = "Delete";
            this.rad_delete.UseVisualStyleBackColor = true;
            this.rad_delete.CheckedChanged += new System.EventHandler(this.rad_delete_CheckedChanged);
            // 
            // lista_pesama
            // 
            this.lista_pesama.BackColor = System.Drawing.SystemColors.Window;
            this.lista_pesama.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lista_pesama.Location = new System.Drawing.Point(2, 71);
            this.lista_pesama.Name = "lista_pesama";
            this.lista_pesama.ReadOnly = true;
            this.lista_pesama.Size = new System.Drawing.Size(525, 353);
            this.lista_pesama.TabIndex = 7;
            this.lista_pesama.Text = "";
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(444, 12);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 23);
            this.btn_execute.TabIndex = 8;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // btn_list1
            // 
            this.btn_list1.Location = new System.Drawing.Point(463, 48);
            this.btn_list1.Name = "btn_list1";
            this.btn_list1.Size = new System.Drawing.Size(31, 23);
            this.btn_list1.TabIndex = 9;
            this.btn_list1.Text = "PL";
            this.btn_list1.UseVisualStyleBackColor = true;
            this.btn_list1.Click += new System.EventHandler(this.btn_list1_Click);
            // 
            // btn_files1
            // 
            this.btn_files1.Location = new System.Drawing.Point(500, 48);
            this.btn_files1.Name = "btn_files1";
            this.btn_files1.Size = new System.Drawing.Size(27, 23);
            this.btn_files1.TabIndex = 10;
            this.btn_files1.Text = "F";
            this.btn_files1.UseVisualStyleBackColor = true;
            this.btn_files1.Click += new System.EventHandler(this.btn_files_Click);
            // 
            // chk_create_subfolder
            // 
            this.chk_create_subfolder.AutoSize = true;
            this.chk_create_subfolder.Location = new System.Drawing.Point(336, 7);
            this.chk_create_subfolder.Name = "chk_create_subfolder";
            this.chk_create_subfolder.Size = new System.Drawing.Size(103, 17);
            this.chk_create_subfolder.TabIndex = 11;
            this.chk_create_subfolder.Text = "Create subfolder";
            this.chk_create_subfolder.UseVisualStyleBackColor = true;
            // 
            // chk_create_playlist
            // 
            this.chk_create_playlist.AutoSize = true;
            this.chk_create_playlist.Location = new System.Drawing.Point(336, 30);
            this.chk_create_playlist.Name = "chk_create_playlist";
            this.chk_create_playlist.Size = new System.Drawing.Size(91, 17);
            this.chk_create_playlist.TabIndex = 12;
            this.chk_create_playlist.Text = "Create playlist";
            this.chk_create_playlist.UseVisualStyleBackColor = true;
            this.chk_create_playlist.CheckedChanged += new System.EventHandler(this.chk_create_playlist_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(531, 426);
            this.Controls.Add(this.chk_create_playlist);
            this.Controls.Add(this.chk_create_subfolder);
            this.Controls.Add(this.btn_files1);
            this.Controls.Add(this.btn_list1);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.lista_pesama);
            this.Controls.Add(this.rad_delete);
            this.Controls.Add(this.rad_move);
            this.Controls.Add(this.rad_copy);
            this.Controls.Add(this.textBox_to);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.btn_to);
            this.Controls.Add(this.btn_from);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PlayList Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_from;
        private System.Windows.Forms.Button btn_to;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.RadioButton rad_copy;
        private System.Windows.Forms.RadioButton rad_move;
        private System.Windows.Forms.RadioButton rad_delete;
        private System.Windows.Forms.RichTextBox lista_pesama;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Button btn_list1;
        private System.Windows.Forms.Button btn_files1;
        private System.Windows.Forms.CheckBox chk_create_subfolder;
        private System.Windows.Forms.CheckBox chk_create_playlist;
    }
}

