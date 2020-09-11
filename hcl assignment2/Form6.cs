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
    public partial class Form6 : Form
    {
        public string updateValue1;
        public string updateValue2;
        public string updateValue3;
        public string updateValue4;
        public string updateValue5;
        public string updateValue6;
        public string updateValue7;
        public Form6()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" )
            {
                this.updateValue1 = textBox7.Text;
                this.updateValue2 = textBox1.Text;
                this.updateValue3 = textBox2.Text;
                this.updateValue4 = textBox3.Text;
                this.updateValue5 = textBox4.Text;
                this.updateValue6 = textBox5.Text;
                this.updateValue7 = textBox6.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("enter all fields!");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.updateValue1 = textBox7.Text;
            this.updateValue2 = textBox1.Text;
            this.updateValue3 = textBox2.Text;
            this.updateValue4 = textBox3.Text;
            this.updateValue5 = textBox4.Text;
            this.updateValue6 = textBox5.Text;
            this.updateValue7 = textBox6.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
