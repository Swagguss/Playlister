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
        private List<TextBox> weightTextBoxes = new List<TextBox>();
        private List<int> recentlyPlayed = new List<int>();
        private List<int> songWeights = new List<int>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;
        int itemSpacing = 25;

        public PlayLister()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadFolderToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
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
            int i = 0;
            foreach (string audio in filteredFiles)
            {
                audioPlayer.currentPlaylist.appendItem(audioPlayer.newMedia(audio));
                Playlist.Items.Add(audio);

                TextBox weightTextBox = new TextBox();
                weightTextBox.Text = "1";
                weightTextBox.Size = new Size(30, Playlist.ItemHeight); // Set a fixed size for the TextBox
                weightTextBox.Location = new Point(5, i * (weightTextBox.Height+itemSpacing-8)); // Add some margin between TextBoxes
                weightTextBox.Parent = weightPanel;
                weightTextBox.Font = new Font("Nirmala UI", 7, FontStyle.Bold); // Set the font to Nirmala UI Bold with a size of 7
                weightTextBox.TextChanged += WeightTextBox_TextChanged;
                weightTextBox.Tag = i;
                weightTextBoxes.Add(weightTextBox);

                songWeights.Add(1); // Initialize the song weights list

                i++;
            }

            if (filteredFiles.Count > 0)
            {
                FileName.Text = "Files Found: " + filteredFiles.Count;

                Playlist.SelectedIndex = currentFile;

                PlayFile(Playlist.SelectedItem.ToString());

                ResizeListBox(Playlist);
            }
            else
            {
                MessageBox.Show("No Audio files found in this folder.");
            }

        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox weightTextBox = (TextBox)sender;
            int index = (int)weightTextBox.Tag;

            if (int.TryParse(weightTextBox.Text, out int weight))
            {
                songWeights[index] = weight;
            }
            else
            {
                MessageBox.Show("Invalid weight value. Please enter a valid integer.");
                weightTextBox.Text = songWeights[index].ToString();
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
        private int GetNextSongIndex()
        {
            int totalWeight = songWeights.Sum();
            if (totalWeight <= 0)
            {
                return new Random().Next(filteredFiles.Count);
            }

            int randomWeight = new Random().Next(totalWeight);
            int currentIndex = 0;
            int accumulatedWeight = 0;

            for (int i = 0; i < songWeights.Count; i++)
            {
                accumulatedWeight += songWeights[i];
                if (randomWeight < accumulatedWeight)
                {
                    currentIndex = i;
                    break;
                }
            }

            return currentIndex;
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
                nextFile = GetNextSongIndex();

                audioPlayer.Ctlcontrols.stop();
                audioPlayer.currentPlaylist.clear();
                audioPlayer.currentPlaylist.appendItem(audioPlayer.newMedia(filteredFiles[nextFile]));

                currentFile = nextFile;
                Playlist.SelectedIndex = currentFile;
                ShowFileName(FileName);

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
                audioPlayer.Ctlcontrols.stop();
                audioPlayer.currentPlaylist.clear();
                audioPlayer.currentPlaylist.appendItem(audioPlayer.newMedia(filteredFiles[index]));

                currentFile = index;

                ShowFileName(FileName);

                audioPlayer.Ctlcontrols.play();
            }
        }

        private void PlayLister_Load(object sender, EventArgs e)
        {

        }

        private void ResizeListBox(ListBox listBox)
        {
            if (listBox.Items.Count == 0)
            {
                listBox.Height = 0;
            }
            else
            {
                int totalItemHeight = 0;
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    totalItemHeight += listBox.GetItemHeight(i);
                }
                int borderHeight = listBox.Height - listBox.ClientSize.Height; // Account for the border height
                listBox.Height = totalItemHeight + borderHeight;
            }
        }

        private void Playlist_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0)
            {
                // Calculate the new item rectangle with additional space below each item
                Rectangle itemRect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 5);

                string songName = Path.GetFileNameWithoutExtension(Playlist.Items[e.Index].ToString());

                using (Brush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(songName, e.Font, brush, itemRect);
                }
            }

            e.DrawFocusRectangle();
        }

        private void Playlist_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            int spaceBelowItem = itemSpacing;
            e.ItemHeight += spaceBelowItem;
        }
    }
}
