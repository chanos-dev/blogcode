using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_1123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.DoubleBuffered(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Enumerable.Range(1, 100).ToList().ForEach(item => listView1.Items.Add(item.ToString()));
        } 
    }

    /// <summary>
    /// Reflection을 이용하여 대입
    /// </summary>
    internal static class ControlExtension
    {
        internal static void DoubleBuffered(this Control control, bool isBuffered)
        {
            var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);

            if (prop is null)
                return;

            prop.SetValue(control, isBuffered);

            // 위에 또는 아래

            control.GetType().InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, control, new object[] { isBuffered });
        }
    }

    /// <summary>
    /// DoubleBuffered가 필요한 컨트롤을 상속받고 생성자에서 대입  
    /// </summary>
    internal class DoubleBufferedListView : ListView
    {
        public DoubleBufferedListView()
        {
            this.DoubleBuffered = true;
        }
    }
}
