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
    public partial class Form3 : Form
    {
        public string setValue1;
        public string setValue2;
        public string setValue3;
        public string setValue4;
        public string setValue5;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {

                this.setValue1 = textBox1.Text;
                this.setValue2 = textBox2.Text;
                this.setValue3 = textBox3.Text;
                this.setValue4 = textBox4.Text;
                this.setValue5 = textBox5.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("enter all fields!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.setValue1 = textBox1.Text;
            this.setValue2 = textBox2.Text;
            this.setValue3 = textBox3.Text;
            this.setValue4 = textBox4.Text;
            this.setValue5 = textBox5.Text;
            
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
