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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Playlister
{
    public partial class PlayLister : Form
    {

        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;
        private List<int> recentlyPlayed = new List<int>();

        public PlayLister()
        {
            InitializeComponent();
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
            }
            else
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MediaPlayerStateChangeEvent(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                lblDuration.Text = "Loaded";
            }
            else if (e.newState == 1)
            {
                lblDuration.Text = "Player stopped";
            }
            else if (e.newState == 3)
            {
                lblDuration.Text = "Duration: " + audioPlayer.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                // Get the next random song
                Random rand = new Random();
                int nextFile;

                do
                {
                    nextFile = rand.Next(filteredFiles.Count);
                } while (recentlyPlayed.Contains(nextFile));

                // Update the list of recently played songs
                recentlyPlayed.Add(nextFile);
                if (recentlyPlayed.Count >= filteredFiles.Count)
                {
                    recentlyPlayed.RemoveAt(0);
                }

                // Update the current media item in the playlist
                audioPlayer.Ctlcontrols.stop();
                audioPlayer.currentPlaylist.clear();
                audioPlayer.currentPlaylist.appendItem(audioPlayer.newMedia(filteredFiles[nextFile]));

                // Update the playlist UI
                currentFile = nextFile;
                Playlist.SelectedIndex = currentFile;
                ShowFileName(FileName);

                // Start playing the new song
                audioPlayer.Ctlcontrols.play();
            }
            else if (e.newState == 9)
            {
                lblDuration.Text = "Loading...";
            }
            else if (e.newState == 10)
            {
                timer1.Start();
            }
        }

        private void PickSongWithDoubleClick(object sender, MouseEventArgs e)
        {
            int index = Playlist.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                // Update the current media item in the playlist
                audioPlayer.Ctlcontrols.stop();
                audioPlayer.currentPlaylist.clear();
                audioPlayer.currentPlaylist.appendItem(audioPlayer.newMedia(filteredFiles[index]));

                // Update the current file index
                currentFile = index;

                // Show the file name
                ShowFileName(FileName);

                // Start playing the selected song
                audioPlayer.Ctlcontrols.play();
            }
        }
    }
}
