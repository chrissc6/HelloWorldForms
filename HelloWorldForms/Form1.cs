using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            x--;
            message.Text = $"{x}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //different way
            message.Text = (++x).ToString();
        }
    }
}
