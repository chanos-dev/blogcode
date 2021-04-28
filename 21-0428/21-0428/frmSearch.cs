using _21_0428.Utils;
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

namespace _21_0428
{
    public partial class frmSearch : Form
    {
        private TextSearch TextSearch { get; set; }
        private List<string> SampleTextList { get; set; }

        public frmSearch()
        {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable()
        {
            TextSearch = new TextSearch();

            SampleTextList = new List<string>();
            var samples = File.ReadAllLines(@"./Sample/Sample.txt");
            SampleTextList.AddRange(samples);
            lbSearchBox.Items.Clear();
            lbSearchBox.Items.AddRange(samples);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (SampleTextList is null)
                return; // throw new NullReferenceException("SearchList is null");

            lbSearchBox.Items.Clear();
            var getTexts = TextSearch.SearchWord(SampleTextList, txtSearch.Text.Trim(), out string searchPattern);
            lbSearchBox.Items.AddRange(getTexts.ToArray());

            lbPattern.Text = $"검색패턴 : {searchPattern}";
        }
    }
}
