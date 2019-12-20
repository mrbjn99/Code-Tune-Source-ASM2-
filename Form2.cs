using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 click = new Form1();
            click.ShowDialog();
            this.Dispose();

        }
    }
}
