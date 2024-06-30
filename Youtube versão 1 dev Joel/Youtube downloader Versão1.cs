using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube_versão_1_dev_Joel
{
    public partial class frYoutube : Form
    {
        public frYoutube()
        {
            InitializeComponent();
            CmbQualidade.Text = "Qualidade";
        }

        private async void BtnMostrar_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, insira uma URL.");
                return;
            }

            try
            {
                CmbQualidade.Items.Clear();
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                if (rdMp3.Checked)
                {
                    var audioStreams = streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate);
                    foreach (var streamInfo in audioStreams)
                    {
                        CmbQualidade.Items.Add($"{streamInfo.Bitrate.KiloBitsPerSecond:F2} Kbps");
                    }
                }
                else if (rdMp4.Checked)
                {
                    var videoStreams = streamManifest.GetMuxedStreams().OrderByDescending(s => s.VideoQuality);
                    foreach (var streamInfo in videoStreams)
                    {
                        CmbQualidade.Items.Add($"{streamInfo.VideoQuality.Label} - {streamInfo.Container.Name}");
                    }
                }

                if (CmbQualidade.Items.Count > 0)
                {
                    CmbQualidade.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nenhuma qualidade disponível encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private async void rdMp3_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdMp3.Checked) return;

            string url = txtUrl.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, insira uma URL.");
                return;
            }

            try
            {
                CmbQualidade.Items.Clear();
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                var audioStreams = streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate);
                foreach (var streamInfo in audioStreams)
                {
                    CmbQualidade.Items.Add($"{streamInfo.Bitrate.KiloBitsPerSecond:F2} Kbps");
                }

                if (CmbQualidade.Items.Count > 0)
                {
                    CmbQualidade.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nenhuma qualidade disponível encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private async void rdMp4_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdMp4.Checked) return;

            string url = txtUrl.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, insira uma URL.");
                return;
            }

            try
            {
                CmbQualidade.Items.Clear();
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                var videoStreams = streamManifest.GetMuxedStreams().OrderByDescending(s => s.VideoQuality);
                foreach (var streamInfo in videoStreams)
                {
                    CmbQualidade.Items.Add($"{streamInfo.VideoQuality.Label} - {streamInfo.Container.Name}");
                }

                if (CmbQualidade.Items.Count > 0)
                {
                    CmbQualidade.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nenhuma qualidade disponível encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string selectedQuality = CmbQualidade.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(url) || selectedQuality == null)
            {
                MessageBox.Show("Por favor, insira uma URL, selecione um formato e uma qualidade.");
                return;
            }

            try
            {
                Avanco.Value = 0;
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                IStreamInfo streamInfo = null;

                if (rdMp3.Checked)
                {
                    streamInfo = streamManifest.GetAudioOnlyStreams()
                                               .FirstOrDefault(s => $"{s.Bitrate.KiloBitsPerSecond:F2} Kbps" == selectedQuality);
                }
                else if (rdMp4.Checked)
                {
                    streamInfo = streamManifest.GetMuxedStreams()
                                               .FirstOrDefault(s => $"{s.VideoQuality.Label} - {s.Container.Name}" == selectedQuality);
                }

                if (streamInfo != null)
                {
                    var fileExtension = streamInfo.Container.Name;
                    var fileName = $"{video.Title}.{fileExtension}";
                    fileName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars())); // Sanitize filename

                    // Show SaveFileDialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = fileName;
                    saveFileDialog.Filter = fileExtension == "mp4" ? "MP4 files (*.mp4)|*.mp4" : "MP3 files (*.mp3)|*.mp3";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = saveFileDialog.FileName;
                        await DownloadStreamAsync(youtube, streamInfo, filePath);
                        MessageBox.Show("Download concluído com sucesso.");
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar a qualidade selecionada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante o download: {ex.Message}");
            }
        }

        private async Task DownloadStreamAsync(YoutubeClient youtube, IStreamInfo streamInfo, string filePath)
        {
            var progress = new Progress<double>(p => Avanco.Value = (int)(p * 100));
            await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath, progress);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtUrl.Clear();
            CmbQualidade.Items.Clear();
            CmbQualidade.Text = "Qualidade";
            rdMp3.Checked = false;
            rdMp4.Checked = false;
            Avanco.Value = 0;
            MessageBox.Show("Os seus dados Foram Limpos Com sucesso!", "Dados",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja sair do programa ? Sim/nao","Sair",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)return;
            Application.Exit();
        }
    }
}
