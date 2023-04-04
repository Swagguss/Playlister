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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.FileName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // audioPlayer
            // 
            this.audioPlayer.Enabled = true;
            this.audioPlayer.Location = new System.Drawing.Point(12, 389);
            this.audioPlayer.Name = "audioPlayer";
            this.audioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audioPlayer.OcxState")));
            this.audioPlayer.Size = new System.Drawing.Size(781, 46);
            this.audioPlayer.TabIndex = 1;
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(82)))));
            this.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlist.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist.ForeColor = System.Drawing.Color.White;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 17;
            this.Playlist.Location = new System.Drawing.Point(811, 44);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(158, 391);
            this.Playlist.TabIndex = 2;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.ForeColor = System.Drawing.Color.White;
            this.FileName.Location = new System.Drawing.Point(12, 366);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(75, 20);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "FileName";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(679, 366);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(88, 20);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration: 0";
            // 
            // PlayLister
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(981, 447);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.audioPlayer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayLister";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer audioPlayer;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Timer timer1;
    }
}

