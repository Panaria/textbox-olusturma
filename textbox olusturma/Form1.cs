using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            txt.Text = "Ronaldo";
            txt.Top = 200;
            txt.Left = 275;
            txt.Width = 300;

            this.Controls.Add(txt);
        }
    }
}
