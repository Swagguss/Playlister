namespace Playlister
{
    partial class PlayLister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayLister));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.FileName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.weightPanel = new System.Windows.Forms.Panel();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).BeginInit();
            this.weightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 5;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveToolStripMenuItem.Text = "Save (not implemented)";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loadToolStripMenuItem.Text = "Load (not implemented)";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fToolStripMenuItem.Text = "New Playlist";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.loadFolderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // loadFolderToolStripMenuItem
            // 
            this.loadFolderToolStripMenuItem.Name = "loadFolderToolStripMenuItem";
            this.loadFolderToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // audioPlayer
            // 
            this.audioPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.audioPlayer.Enabled = true;
            this.audioPlayer.Location = new System.Drawing.Point(0, 398);
            this.audioPlayer.Name = "audioPlayer";
            this.audioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audioPlayer.OcxState")));
            this.audioPlayer.Size = new System.Drawing.Size(605, 46);
            this.audioPlayer.TabIndex = 1;
            this.audioPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayerStateChangeEvent);
            // 
            // FileName
            // 
            this.FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.ForeColor = System.Drawing.Color.White;
            this.FileName.Location = new System.Drawing.Point(22, 44);
            this.FileName.MaximumSize = new System.Drawing.Size(590, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(75, 20);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "FileName";
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(467, 375);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(88, 20);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // weightPanel
            // 
            this.weightPanel.AutoScroll = true;
            this.weightPanel.Controls.Add(this.Playlist);
            this.weightPanel.Location = new System.Drawing.Point(611, 44);
            this.weightPanel.Name = "weightPanel";
            this.weightPanel.Size = new System.Drawing.Size(358, 391);
            this.weightPanel.TabIndex = 6;
            // 
            // Playlist
            // 
            this.Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(86)))));
            this.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Playlist.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist.ForeColor = System.Drawing.Color.White;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 12;
            this.Playlist.Location = new System.Drawing.Point(127, 0);
            this.Playlist.Name = "Playlist";
            this.Playlist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Playlist.Size = new System.Drawing.Size(227, 390);
            this.Playlist.TabIndex = 1;
            this.Playlist.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Playlist_DrawItem);
            this.Playlist.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Playlist_MeasureItem);
            this.Playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PickSongWithDoubleClick);
            // 
            // PlayLister
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(977, 444);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.audioPlayer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.weightPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayLister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlister";
            this.Load += new System.EventHandler(this.PlayLister_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).EndInit();
            this.weightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer audioPlayer;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel weightPanel;
        private System.Windows.Forms.ListBox Playlist;
    }
}
