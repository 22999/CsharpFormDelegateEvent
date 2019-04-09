using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public delegate void ChangeFormColor(bool topmost);
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public event  ChangeFormColor ChangeColor;
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeColor(true);
        }
    }
}
