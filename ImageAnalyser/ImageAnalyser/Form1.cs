using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private async void buttonAnalyzeImage_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                string analysis = await CallOpenAI(imageBytes);
                textBoxAnalysis.Text = analysis;
            }
        }

        private async Task<string> CallOpenAI(byte[] imageBytes)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "");

                string imageString = Convert.ToBase64String(imageBytes);
                var content = new StringContent(imageString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
                string responseString = await response.Content.ReadAsStringAsync();

                string analysis = ProcessResponse(responseString);

                return analysis;
            }
        }

        private string ProcessResponse(string responseString)
        {
            JObject responseJson = JObject.Parse(responseString);
            string analysis = (string)responseJson["analysis"];
            return analysis;
        }
    }
}
