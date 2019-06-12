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

        List<Line> lines = new List<Line>();

        async void HladajButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.Columns.Clear();
            lines.Clear();

            MainBrowser.Navigate("https://cp.hnonline.sk/" + GetTransportMethod() + "/odchody/");
            await PageLoad(10);
            MainBrowser.Focus();

            SendKeys.Send("%{o}");         //access key which selects the field
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

            var tr = MainBrowser.Document.GetElementsByTagName("tr");

            Regex rL = new Regex(@"javascript:.+?\)");

            List<string> pages = rL.Matches(tr[1].InnerHtml).Cast<Match>().Select(match => match.Value).ToList();

            await GetLinesFromPage("", tr);
            foreach (string page in pages)
            {
                await GetLinesFromPage(page, tr);
            }
            dataGridView1.Visible = true;
            ShowResults();
        }

        //TODO Multipge results switching

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

        async Task GetLinesFromPage(string page, HtmlElementCollection tr)
        {
            if (page != "")
                MainBrowser.Document.InvokeScript(page);

            List<string> links = new List<string>();
            Regex rS = new Regex("\"/draha/.*?\"");

            foreach (HtmlElement element in tr)
            {
                string test = rS.Match(element.InnerHtml).Value;

                if (test != "")
                {
                    test = test.Replace("\"", "");
                    links.Add(test);
                }
            }

            foreach (string s in links)
            {
                MainBrowser.Navigate("https://cp.hnonline.sk" + s);
                await PageLoad(1);
                tr = MainBrowser.Document.GetElementsByTagName("tr");
                lines.Add(new Line());
                for (int i = 1; i < tr.Count - 1; i++)
                {
                    if (tr[i].Children[0].OuterHtml.Contains("EndDark") || tr[i].Children[0].OuterHtml.Contains("lastRouteDark"))
                    {
                        lines.Last().AddStop(tr[i].Children[0].InnerText, tr[i].Children[1].InnerText == " " ? tr[i].Children[2].InnerText : tr[i].Children[1].InnerText);
                        break;
                    }
                    else if (tr[i].Children[0].OuterHtml.Contains("Dark"))
                        lines.Last().AddStop(tr[i].Children[0].InnerText, tr[i].Children[2].InnerText);
                }
            }
        }

        void ShowResults()
        {
            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 0; j < lines[i].GetNumOfStops(); j++)
                {
                    string stop = lines[i].GetStop(j).Item1;
                    string time = lines[i].GetStop(j).Item2;

                    if (!dataGridView1.Columns.Contains(stop))
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            HeaderText = stop,
                            Name = stop
                        });
                        if (dataGridView1.Rows.Count < 2)
                            dataGridView1.Rows.Add(lines.Count);
                    }
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[stop];
                    dataGridView1.CurrentCell.Value = time;
                }
            }
        }

        async Task PageLoad(int TimeOut)
        {
            
            TaskCompletionSource<bool> PageLoaded = null;
            PageLoaded = new TaskCompletionSource<bool>();
            int TimeElapsed = 0;

            MainBrowser.DocumentCompleted += (s, e) =>
            {
                if (MainBrowser.ReadyState != WebBrowserReadyState.Complete) return;
                if (PageLoaded.Task.IsCompleted) return; PageLoaded.SetResult(true);
            };

            while (PageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(10); //10ms works just fine, might change this later
                TimeElapsed++;
                if (TimeElapsed >= TimeOut * 100) PageLoaded.TrySetResult(true);
            }
            
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            dataGridView1.ClearSelection();
        }
    }
}
