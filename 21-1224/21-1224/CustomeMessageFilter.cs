using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_1224
{
    internal class CustomMessageFilter : IMessageFilter
    {
        private ListBox ListBox { get; set; }

        public CustomMessageFilter(ListBox listBox)
        {
            this.ListBox = listBox;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x201)
            {
                ListBox.Items.Add($"선 처리!! | {m}");
                // return true;
            }

            return false;
        }
    }
}
