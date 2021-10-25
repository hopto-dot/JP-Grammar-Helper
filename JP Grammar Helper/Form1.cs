using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_Grammar_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createDatabase_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String HTML = string.Empty;
            HTML = client.DownloadString(new Uri ("https://nihongokyoshi-net.com/jlpt-grammars/"));
            HTML = HTML.Replace("span id=\"N", "`");
            String[] grammarLevels = HTML.Split("`");
            List<String[]> grammar = new List<string[]> { };
            for (int i = 1; i < 6; i++)
            {
                grammarLevels[i] = grammarLevels[i].Replace("</a>", "`");
            }

            for (int i = 1; i < 6; i++)
            {
                grammar.Add(grammarLevels[i].Split("`"));
            }

            Debug.WriteLine("Imported database!");
        }
    }
}
