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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ChangeColor += f_ChangeColor;
            f.Show();

        }

        void f_ChangeColor(bool topmost)
        {
            //throw new NotImplementedException();
            this.BackColor = Color.LightBlue;
            this.Text = "改变成功";
        }
    }
}
