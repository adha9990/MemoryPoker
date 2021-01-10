using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPoker.Views
{
    public partial class SetPrepareMemoryTime : Form
    {
        public SetPrepareMemoryTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int time
        {
            get { return (int)numericUpDown1.Value; }
        }
    }
}
