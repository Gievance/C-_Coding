using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using AsyncDelivery.Tools;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AsyncDelivery
{
    public partial class HttpAsync : Form
    {
        public HttpAsync()
        {
            InitializeComponent();
        }

        private string[] urls =
        {
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/Abracadabra.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/Apple.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/HelloWorld.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/KrnlsYs.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/Microsoft.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/VisualStudio.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/async.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/await.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/csharp.txt",
            "https://raw.githubusercontent.com/KrnlsYs/AsyncExample/refs/heads/main/dotnet.txt",
        };
        private HttpClient httpClient = new HttpClient();
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            var sw = Stopwatch.StartNew();

            foreach(var url in urls)
            {
                textBox1.AppendText(httpClient.GetStringAsync(url).GetAwaiter().GetResult().Replace("\n",Environment.NewLine));
                textBox1.AppendText(Environment.NewLine + Environment.NewLine);
            }
            sw.Stop();
            MessageBox.Show($"{sw.ElapsedMilliseconds}");
        }
        /// <summary>
        /// 进行异步操作不影响UI界面操作，并没有提升性能，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            var sw = Stopwatch.StartNew();
            foreach (var url in urls)
            {
                textBox1.AppendText(
                    (await httpClient.GetStringAsync(url)).Replace("\n", Environment.NewLine));
                textBox1.AppendText(Environment.NewLine + Environment.NewLine);
            }

            sw.Stop();
            MessageBox.Show($"{sw.ElapsedMilliseconds}");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            var sw = Stopwatch.StartNew();

            var result = await Task.WhenAll(urls.Select(httpClient.GetStringAsync));
            
            foreach(var s in result)
            {
                textBox1.AppendText(s.Replace("\n", Environment.NewLine));
                textBox1.AppendText(Environment.NewLine + Environment.NewLine);
            }

            sw.Stop();
            MessageBox.Show($"{sw.ElapsedMilliseconds}");
        }

        private void HttpAsync_Load(object sender, EventArgs e)
        {

        }
    }
}
