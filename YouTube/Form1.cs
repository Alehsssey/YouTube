using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace ytv
{
    public partial class Form1 : Form
    {     

        public Form1()
        {
            InitializeComponent();
            btndownload.Enabled = false;
            cbresolution.Enabled = false;
        }

        private async void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Helper.isValidUrl(tburl.Text) || !tburl.Text.ToLower().Contains("www.youtube.com/watch?"))
                {
                    MessageBox.Show(this, "Ви ввели недійсну URL-адресу YouTube, виправте її.\r\n\nПримітка: URL-адреса повинна починатися з: \r\nhttp://www.youtube.com/watch?",
                          "Недійсна URL-адреса", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pbpreview.ImageLocation = string.Format("http://i3.ytimg.com/vi/{0}/default.jpg", Helper.GetVideoIDFromUrl(tburl.Text));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            YoutubeClient client = new YoutubeClient();

            try
            {
                var video = await client.Videos.GetAsync(tburl.Text);
                lblname.Text = video.Title;
                lblduration.Text = video.Duration.ToString();

                var streamManifest = await client.Videos.Streams.GetManifestAsync(tburl.Text);
                var streamInfo = streamManifest.GetMuxedStreams();
                var l = streamInfo.ToList();
                cbresolution.Items.Clear();
                for (int i = 0; i < l.Count; i++)
                {
                    cbresolution.Items.Add(l[i].VideoQuality);
                }
                cbresolution.SelectedIndex = 0;
                btndownload.Enabled = true;
                cbresolution.Enabled = true;
            }
            catch
            { }

        }
        private async void btndownload_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {

                        YoutubeClient client = new YoutubeClient();

                        var video = await client.Videos.GetAsync(tburl.Text);
                        var streamManifest = await client.Videos.Streams.GetManifestAsync(tburl.Text);
                        var streamInfo = streamManifest.GetMuxedStreams();

                        var l = streamInfo.ToList();

                        var progress = new Progress<double>();
                        progress.ProgressChanged += Progress_ProgressChanged1;
                        MessageBox.Show("Завантаження почалося");
                        btndownload.Enabled = false;
                        await client.Videos.Streams.DownloadAsync(l[cbresolution.SelectedIndex] as MuxedStreamInfo, fbd.SelectedPath + video.Title + streamInfo.ToList()[cbresolution.SelectedIndex].VideoQuality + ".mp4", progress);
                        MessageBox.Show("Завантаження завершено");
                    }
                    else
                    {
                        btndownload.Enabled = true;
                        MessageBox.Show("Виберіть шлях до файлу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Progress_ProgressChanged1(object sender, double e)
        {
            progressBar1.Value = Convert.ToInt32(e*100);
        }


        private void btnpaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() == true)
            {
                tburl.Text = Clipboard.GetText();
            }
            else
            {               
                MessageBox.Show(this, "В буфері обміну немає тексту", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tburl.Text);
        }

        private void tburl_TextChanged(object sender, EventArgs e)
        {
            btndownload.Enabled = false;
            cbresolution.Enabled = false;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void інструкціяКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void cbresolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
