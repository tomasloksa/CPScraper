/*Tomáš Lokša 2019*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace CPScraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void HladajButton_Click(object sender, EventArgs e)
        {
            TempBrowser.Navigate("https://cp.hnonline.sk/" + GetTransportMethod() + "/odchody/");
            await PageLoad(10);

            TempBrowser.Focus();
            SendKeys.Send("%{o}");
            SendKeys.Send(ZTextBox.Text);

            SendKeys.Send("%{k}");
            SendKeys.Send(DoTextBox.Text);

            SendKeys.Send("%{t}");
            SendKeys.Send(datumPicker.Value.ToString("d.M.yyyy"));

            SendKeys.Send("%{a}");
            SendKeys.Send("00:00");

            SendKeys.SendWait("{ENTER}");
            await PageLoad(10);
            await PageLoad(10);

            var tr = TempBrowser.Document.GetElementsByTagName("tr");
            List<string> links = new List<string>();
            Regex r1 = new Regex("\"/draha/.*?\"");

            foreach (HtmlElement element in tr)
            {
                string test = r1.Match(element.InnerHtml).Value;
                if (test != "")
                {
                    test = test.Replace("\"", "");
                    links.Add(test);
                }
            }

            List<Line> lines = new List<Line>();

            foreach (string s in links)
            {
                TempBrowser.Navigate("https://cp.hnonline.sk" + s);
                await PageLoad(10);
                tr = TempBrowser.Document.GetElementsByTagName("tr");
                lines.Add(new Line());
                for (int i = 1; i < tr.Count - 1; i++)
                {
                    if (tr[i].Children[0].OuterHtml.Contains("EndDark") || tr[i].Children[0].OuterHtml.Contains("lastRouteDark"))
                    {
                        lines.Last().AddStop(tr[i].Children[0].InnerText, tr[i].Children[1].InnerText);
                        break;
                    }
                    else if (tr[i].Children[0].OuterHtml.Contains("Dark"))
                        lines.Last().AddStop(tr[i].Children[0].InnerText, tr[i].Children[2].InnerText);
                }
            }
        }

        //TODO multipage results
        //TODO Excel export

        string GetTransportMethod()
        {
            string transportMethod = "";
            if (VlakCheckbox.Checked)
                transportMethod += "vlak";
            if (BusCheckbox.Checked)
                transportMethod += "bus";
            if (MHDCheckbox.Checked)
                transportMethod += "MHD";
            return transportMethod;
        }

        async Task PageLoad(int TimeOut)
        {
            TaskCompletionSource<bool> PageLoaded = null;
            PageLoaded = new TaskCompletionSource<bool>();
            int TimeElapsed = 0;
            TempBrowser.DocumentCompleted += (s, e) =>
            {
                if (TempBrowser.ReadyState != WebBrowserReadyState.Complete) return;
                if (PageLoaded.Task.IsCompleted) return; PageLoaded.SetResult(true);
            };

            while (PageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(10);//10ms works just fine, might change this later
                TimeElapsed++;
                if (TimeElapsed >= TimeOut * 100) PageLoaded.TrySetResult(true);
            }
        }
    }
}
