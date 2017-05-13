namespace MusicApp
{
    partial class test
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.b = new MusicApp.MusicAlbumDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cat = new System.Windows.Forms.TextBox();
            this.openfile = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.Ref = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.shufflesong = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ListTracks = new System.Windows.Forms.ListBox();
            this.TxtFolder = new System.Windows.Forms.TextBox();
            this.ButFolder = new System.Windows.Forms.Button();
            this.Butclose = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trackNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AlbumSongTableAdapter = null;
            this.b.BackupDataSetBeforeUpdate = false;
            this.b.Connection = null;
            this.b.SongTableAdapter = null;
            this.b.UpdateOrder = MusicApp.MusicAlbumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Folk",
            "Hip Hop",
            "Classic",
            "Jazz",
            "Rock",
            "Rap"});
            this.comboBox1.Location = new System.Drawing.Point(465, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // Cat
            // 
            this.Cat.Location = new System.Drawing.Point(758, 135);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(100, 20);
            this.Cat.TabIndex = 36;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(758, 100);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(100, 20);
            this.openfile.TabIndex = 35;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.Color.White;
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.category.Location = new System.Drawing.Point(665, 142);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(75, 19);
            this.category.TabIndex = 34;
            this.category.Text = "Category";
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sname.Location = new System.Drawing.Point(650, 107);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(93, 19);
            this.Sname.TabIndex = 33;
            this.Sname.Text = "Song Name";
            // 
            // Ref
            // 
            this.Ref.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ref.Location = new System.Drawing.Point(876, 302);
            this.Ref.Name = "Ref";
            this.Ref.Size = new System.Drawing.Size(75, 23);
            this.Ref.TabIndex = 32;
            this.Ref.Text = "Refresh";
            this.Ref.UseVisualStyleBackColor = true;
            // 
            // Browse
            // 
            this.Browse.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Browse.Location = new System.Drawing.Point(876, 100);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 31;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(701, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Delete from PlayList";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PlayList
            // 
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(642, 340);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(309, 147);
            this.PlayList.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(829, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Create PlayList";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Location = new System.Drawing.Point(228, 62);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(63, 23);
            this.Next.TabIndex = 27;
            this.Next.Text = "Next>>";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // shufflesong
            // 
            this.shufflesong.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shufflesong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shufflesong.Location = new System.Drawing.Point(161, 62);
            this.shufflesong.Name = "shufflesong";
            this.shufflesong.Size = new System.Drawing.Size(72, 23);
            this.shufflesong.TabIndex = 26;
            this.shufflesong.Text = "Shuffle";
            this.shufflesong.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // ListTracks
            // 
            this.ListTracks.FormattingEnabled = true;
            this.ListTracks.Location = new System.Drawing.Point(174, 107);
            this.ListTracks.Name = "ListTracks";
            this.ListTracks.Size = new System.Drawing.Size(172, 147);
            this.ListTracks.TabIndex = 25;
            // 
            // TxtFolder
            // 
            this.TxtFolder.Enabled = false;
            this.TxtFolder.Location = new System.Drawing.Point(173, 433);
            this.TxtFolder.Name = "TxtFolder";
            this.TxtFolder.Size = new System.Drawing.Size(182, 20);
            this.TxtFolder.TabIndex = 24;
            // 
            // ButFolder
            // 
            this.ButFolder.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButFolder.Location = new System.Drawing.Point(361, 430);
            this.ButFolder.Name = "ButFolder";
            this.ButFolder.Size = new System.Drawing.Size(103, 23);
            this.ButFolder.TabIndex = 23;
            this.ButFolder.Text = "Select Songs";
            this.ButFolder.UseVisualStyleBackColor = true;
            // 
            // Butclose
            // 
            this.Butclose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butclose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Butclose.Location = new System.Drawing.Point(288, 62);
            this.Butclose.Name = "Butclose";
            this.Butclose.Size = new System.Drawing.Size(58, 23);
            this.Butclose.TabIndex = 22;
            this.Butclose.Text = "Close";
            this.Butclose.UseVisualStyleBackColor = true;
            this.Butclose.Click += new System.EventHandler(this.Butclose_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackNameToolStripMenuItem,
            this.toolStripSeparator1,
            this.playPauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 148);
            // 
            // trackNameToolStripMenuItem
            // 
            this.trackNameToolStripMenuItem.Name = "trackNameToolStripMenuItem";
            this.trackNameToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.trackNameToolStripMenuItem.Text = "Track Name";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nextToolStripMenuItem.Text = "Next";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeatToolStripMenuItem,
            this.repeatAllToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            // 
            // repeatAllToolStripMenuItem
            // 
            this.repeatAllToolStripMenuItem.Name = "repeatAllToolStripMenuItem";
            this.repeatAllToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.repeatAllToolStripMenuItem.Text = "Repeat All";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(613, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicApp.Properties.Resources.shadow_warrior_4;
            this.ClientSize = new System.Drawing.Size(1113, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.category);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Ref);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.shufflesong);
            this.Controls.Add(this.ListTracks);
            this.Controls.Add(this.TxtFolder);
            this.Controls.Add(this.ButFolder);
            this.Controls.Add(this.Butclose);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "test";
            this.Text = "test";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private MusicAlbumDataSetTableAdapters.TableAdapterManager b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Cat;
        private System.Windows.Forms.TextBox openfile;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Button Ref;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button shufflesong;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ListBox ListTracks;
        private System.Windows.Forms.TextBox TxtFolder;
        private System.Windows.Forms.Button ButFolder;
        private System.Windows.Forms.Button Butclose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem trackNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button4;
    }
}