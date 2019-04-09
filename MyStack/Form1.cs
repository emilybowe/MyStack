using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStack
{
    public partial class Form1 : Form
    {
        StackOfInt s = new StackOfInt();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.push(int.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + s.pop();
        }
    }
}
