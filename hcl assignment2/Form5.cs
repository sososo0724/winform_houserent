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
    public partial class Form5 : Form
    {
        public string field1;
        public string field2;
        public string field3;
        public string field4;
        public string field5;
        public string field6;
        public string field7;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                this.field1 = textBox5.Text;
                this.field2 = textBox2.Text;
                this.field3 = textBox3.Text;
                this.field4 = textBox1.Text;
                this.field5 = textBox4.Text;
                this.field6 = textBox6.Text;
                this.field7 = textBox7.Text;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.field1 = textBox5.Text;
            this.field2 = textBox2.Text;
            this.field3 = textBox3.Text;
            this.field4 = textBox1.Text;
            this.field5 = textBox4.Text;
            this.field6 = textBox6.Text;
            this.field7 = textBox7.Text;
        }
    }
}
