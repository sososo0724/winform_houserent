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
    public partial class Form7 : Form
    {
        public string fvalue1;
        public string fvalue2;
        public string fvalue3;
        public string fvalue4;
        public string fvalue5;
        public string fvalue6;
        public string fvalue7;

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox5.Text != "") {
            
                this.fvalue1 = textBox1.Text;
                this.fvalue2 = textBox2.Text;
                this.fvalue3 = textBox3.Text;
                this.fvalue4 = textBox4.Text;
                this.fvalue5 = textBox5.Text;
                this.fvalue6 = textBox6.Text;
                this.fvalue7 = textBox7.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("enter all fields !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.fvalue1 = textBox1.Text;
            this.fvalue2 = textBox2.Text;
            this.fvalue3 = textBox3.Text;
            this.fvalue4 = textBox4.Text;
            this.fvalue5 = textBox5.Text;
            this.fvalue6 = textBox6.Text;
            this.fvalue7 = textBox7.Text;
        }
    }
}
