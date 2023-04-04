using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Playlister
{
    public partial class PlayLister : Form
    {

        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;

        string prevText = "";

        public PlayLister()
        {
            InitializeComponent();
        }

        private void PlayLister_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) // file menu event
        {

        }

        private void loadFolderToolStripMenuItem_Click(object sender, EventArgs e) // Load Folder Event
        {
            audioPlayer.Ctlcontrols.stop();

            if (filteredFiles.Count > 1)
            {
                filteredFiles.Clear();
                filteredFiles = null;

                Playlist.Items.Clear();
                currentFile = 0;
            }

            DialogResult result = browser.ShowDialog();

            if (result == DialogResult.OK)
            {
                filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("mp3") || file.ToLower().EndsWith("wav")).ToList();

                LoadPlaylist();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) // options menu event
        {

        }

        private void MediaPlayerStateChangedEvent(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                lblDuration.Text = "Loaded";
            } else if (e.newState == 1)
            {
                lblDuration.Text = "Player stopped";
            } else if (e.newState == 3)
            {
                lblDuration.Text = "Duration: " + audioPlayer.currentMedia.durationString;
            } else if (e.newState == 8)
            {
                int lastFile = currentFile;
                if (currentFile >= filteredFiles.Count - 1)
                {
                    currentFile = 0;
                } else
                {
                    Random rand = new Random();

                    int tryrand = rand.Next(filteredFiles.Count);

                    if (tryrand > filteredFiles.Count)
                    {
                        currentFile = tryrand;
                    } else
                    {
                        tryrand = rand.Next(filteredFiles.Count);
                    }
                }

                Playlist.SelectedIndex = currentFile;
                ShowFileName(FileName);
            } else if (e.newState == 9)
            {
                lblDuration.Text = "Loading...";
            } else if (e.newState == 10)
            {
                timer1.Start();
            }
        }

        private void PlaylistChanged(object sender, EventArgs e)
        {
            currentFile = Playlist.SelectedIndex;
            PlayFile(Playlist.SelectedItem.ToString());
            ShowFileName(FileName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimerEvent(object sender, EventArgs e)
        {
            audioPlayer.Ctlcontrols.play();
            timer1.Stop();
        }

        private void LoadPlaylist()
        {
            audioPlayer.currentPlaylist = audioPlayer.newPlaylist("Playlist", "");

            foreach (string audio in filteredFiles)
            {
                audioPlayer.currentPlaylist.appendItem(audioPlayer.newMedia(audio));
                Playlist.Items.Add(audio);
            }

            if (filteredFiles.Count > 0)
            {
                FileName.Text = "Files Found: " + filteredFiles.Count;

                Playlist.SelectedIndex = currentFile;

                PlayFile(Playlist.SelectedItem.ToString());
            } else
            {
                MessageBox.Show("No Audio files found in this folder.");
            }
        }

        private void PlayFile(string url)
        {
            audioPlayer.URL = url;
        }

        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(Playlist.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }
    }  
}
