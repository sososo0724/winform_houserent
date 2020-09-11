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
    public partial class Form4 : Form
    {

        public string value1;
        public string value2;
        public string value3;
        public string value4;
        public string value5;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          
            this.value1 = textBox1.Text;
            this.value2 = textBox2.Text;
            this.value3 = textBox3.Text;
            this.value4 = textBox4.Text;
            this.value5 = textBox5.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                this.value1 = textBox1.Text;
                this.value2 = textBox2.Text;
                this.value3 = textBox3.Text;
                this.value4 = textBox4.Text;
                this.value5 = textBox5.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("enter all field");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
