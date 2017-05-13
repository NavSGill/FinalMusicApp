namespace MusicApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Butclose = new System.Windows.Forms.Button();
            this.ButFolder = new System.Windows.Forms.Button();
            this.TxtFolder = new System.Windows.Forms.TextBox();
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.shufflesong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.Ref = new System.Windows.Forms.Button();
            this.Sname = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.TextBox();
            this.Cat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b = new MusicApp.MusicAlbumDataSetTableAdapters.TableAdapterManager();
            this.button3 = new System.Windows.Forms.Button();
            this.WMD = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMD)).BeginInit();
            this.SuspendLayout();
            // 
            // Butclose
            // 
            this.Butclose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butclose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Butclose.Location = new System.Drawing.Point(167, 398);
            this.Butclose.Name = "Butclose";
            this.Butclose.Size = new System.Drawing.Size(58, 23);
            this.Butclose.TabIndex = 1;
            this.Butclose.Text = "Close";
            this.Butclose.UseVisualStyleBackColor = true;
            this.Butclose.Click += new System.EventHandler(this.butclose);
            // 
            // ButFolder
            // 
            this.ButFolder.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButFolder.Location = new System.Drawing.Point(200, 369);
            this.ButFolder.Name = "ButFolder";
            this.ButFolder.Size = new System.Drawing.Size(103, 23);
            this.ButFolder.TabIndex = 1;
            this.ButFolder.Text = "Select Songs";
            this.ButFolder.UseVisualStyleBackColor = true;
            this.ButFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFolder
            // 
            this.TxtFolder.Enabled = false;
            this.TxtFolder.Location = new System.Drawing.Point(12, 372);
            this.TxtFolder.Name = "TxtFolder";
            this.TxtFolder.Size = new System.Drawing.Size(182, 20);
            this.TxtFolder.TabIndex = 2;
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
            this.contextMenuStrip.Size = new System.Drawing.Size(138, 148);
            // 
            // trackNameToolStripMenuItem
            // 
            this.trackNameToolStripMenuItem.Name = "trackNameToolStripMenuItem";
            this.trackNameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.trackNameToolStripMenuItem.Text = "Track Name";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nextToolStripMenuItem.Text = "Next";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeatToolStripMenuItem,
            this.repeatAllToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // shufflesong
            // 
            this.shufflesong.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shufflesong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shufflesong.Location = new System.Drawing.Point(231, 398);
            this.shufflesong.Name = "shufflesong";
            this.shufflesong.Size = new System.Drawing.Size(72, 23);
            this.shufflesong.TabIndex = 4;
            this.shufflesong.Text = "Shuffle";
            this.shufflesong.UseVisualStyleBackColor = true;
            this.shufflesong.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(668, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add to PlayList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // PlayList
            // 
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(12, 56);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(291, 147);
            this.PlayList.TabIndex = 6;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.ListTracks_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(300, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete from PlayList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Browse
            // 
            this.Browse.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Browse.Location = new System.Drawing.Point(715, 39);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 8;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Ref
            // 
            this.Ref.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ref.Location = new System.Drawing.Point(300, 0);
            this.Ref.Name = "Ref";
            this.Ref.Size = new System.Drawing.Size(75, 23);
            this.Ref.TabIndex = 9;
            this.Ref.Text = "Refresh";
            this.Ref.UseVisualStyleBackColor = true;
            this.Ref.Click += new System.EventHandler(this.Ref_Click);
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sname.Location = new System.Drawing.Point(489, 46);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(93, 19);
            this.Sname.TabIndex = 10;
            this.Sname.Text = "Song Name";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.Color.White;
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.category.Location = new System.Drawing.Point(504, 81);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(75, 19);
            this.category.TabIndex = 11;
            this.category.Text = "Category";
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(597, 39);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(100, 20);
            this.openfile.TabIndex = 12;
            this.openfile.TextChanged += new System.EventHandler(this.openfile_TextChanged);
            // 
            // Cat
            // 
            this.Cat.Location = new System.Drawing.Point(597, 74);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(100, 20);
            this.Cat.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Music";
            // 
            // b
            // 
            this.b.AlbumSongTableAdapter = null;
            this.b.BackupDataSetBeforeUpdate = false;
            this.b.Connection = null;
            this.b.SongTableAdapter = null;
            this.b.UpdateOrder = MusicApp.MusicAlbumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WMD
            // 
            this.WMD.Enabled = true;
            this.WMD.Location = new System.Drawing.Point(12, 199);
            this.WMD.Name = "WMD";
            this.WMD.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMD.OcxState")));
            this.WMD.Size = new System.Drawing.Size(291, 164);
            this.WMD.TabIndex = 0;
            this.WMD.Enter += new System.EventHandler(this.WMD_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 432);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.category);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Ref);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shufflesong);
            this.Controls.Add(this.TxtFolder);
            this.Controls.Add(this.ButFolder);
            this.Controls.Add(this.Butclose);
            this.Controls.Add(this.WMD);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mp3 Player";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Butclose;
        private System.Windows.Forms.Button ButFolder;
        private System.Windows.Forms.TextBox TxtFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
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
        private System.Windows.Forms.Button shufflesong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Ref;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox openfile;
        private System.Windows.Forms.TextBox Cat;
        private System.Windows.Forms.Label label1;
        private MusicAlbumDataSetTableAdapters.TableAdapterManager b;
        private System.Windows.Forms.Button button3;
        private AxWMPLib.AxWindowsMediaPlayer WMD;
        private System.Windows.Forms.TextBox textBox1;
    }
}

