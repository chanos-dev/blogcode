using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_1021
{
    public partial class FormProcess : Form
    {
        public FormProcess()
        {
            InitializeComponent();
        }

        private void button_Process_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Process.Text))
                return;

            Process.Start(textBox_Process.Text);
        }
    }
}
