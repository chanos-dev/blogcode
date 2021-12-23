using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_1224
{
    public partial class Form1 : Form
    {
        private IMessageFilter Filter { get; set; }
        public Form1()
        {
            InitializeComponent();
            Filter = new CustomMessageFilter(this.listBox1);
            Application.AddMessageFilter(Filter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new Form2())
            {
                //Application.RemoveMessageFilter(Filter);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("버튼 클릭!!");
        }
    }
}
