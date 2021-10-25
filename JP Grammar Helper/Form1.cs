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
            cbbLevel.Hide();
        }

        List<List<grammar>> grammarNLevels = new List<List<grammar>>();
        private void createDatabase_Click(object sender, EventArgs e)
        {
            grammarNLevels.Clear();
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

            int nLevel = 5;
            foreach (string[] level in grammar)
            {
                List<grammar> grammarNLevel = new List<grammar>();
                foreach (string grammarString in level)
                {
                    grammar newGrammer = new grammar();
                    string stringTemp = grammarString;

                    int stringIndex = stringTemp.IndexOf("https://nihongokyoshi-net.com");
                    try
                    {
                        stringTemp = stringTemp.Substring(stringIndex);
                        stringIndex = stringTemp.IndexOf("\"");
                        stringTemp = stringTemp.Substring(0, stringIndex).Replace(@"\", "");
                        newGrammer.link = stringTemp;

                        stringTemp = grammarString;
                        stringIndex = stringTemp.IndexOf("・");
                        stringTemp = stringTemp.Substring(stringIndex);
                        stringIndex = stringTemp.IndexOf("<");
                        if (stringIndex != -1) { stringTemp = stringTemp.Substring(0, stringIndex).Replace(@"\", ""); }

                        newGrammer.name = stringTemp;
                    } catch
                    {
                        Console.WriteLine($"Failed grammar");
                        continue;
                    }
                    grammarNLevel.Add(newGrammer);


                    Console.WriteLine();
                }
                grammarNLevels.Add(grammarNLevel);
                nLevel -= 1;
            }

            cbbLevel.Show();
            Debug.WriteLine("Imported database!");
        }

        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbGrammar.Items.Clear();
            if (grammarNLevels.Count < 2) { return; }

            foreach (grammar grammarObject in grammarNLevels[5 - int.Parse(cbbLevel.Text.Replace("N", ""))])
            {
                lbGrammar.Items.Add(grammarObject.name);
            }
        }
    }
}
