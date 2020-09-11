using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hcl_assignment2
{
    public partial class Form10 : Form
    {

        
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
           
            label10.Text =Form1.l1;         
            label14.Text = Form1.l2;
            label5.Text = Form1.l3;
            label28.Text = Form1.l4;
            label31.Text = Form1.l5;
            label32.Text = Form1.l6;
            label33.Text = Form1.l7;
            label34.Text = Form1.l8;
            label35.Text = Form1.l9;
            label27.Text=Form1.l3;
            label29.Text = Form1.l10;
            label30.Text = Form1.l11;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label28_Click(object sender, EventArgs e)
        {
           
        }
    }
}
