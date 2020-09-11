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
    public partial class Form9 : Form
    {
        public string A;
        public string B;
        public string C;
        public string D;
        public string E;
        public string F;
        public string G;
        public string H;
        public string I;
        public string J;
        public Form9()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if ( textBox2.Text != "" && textBox3.Text !="" && textBox4.Text!= "")
            {
                this.A = textBox1.Text;
                this.B = textBox2.Text;
                this.C = textBox3.Text;
                this.D = textBox4.Text;
                this.E= textBox5.Text;
                this.F = textBox6.Text;
                this.G = textBox7.Text;
                this.H = textBox8.Text;
                this.I = textBox9.Text;
                this.J = textBox10.Text;
                    
                this.Close();
               
            }
            else
            {
                MessageBox.Show("enter all fields!");
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.A = textBox1.Text;
            this.B = textBox2.Text;
            this.C = textBox3.Text;
            this.D = textBox4.Text;
            this.E = textBox5.Text;
            this.F = textBox6.Text;
            this.G = textBox7.Text;
            this.H = textBox8.Text;
            this.I = textBox9.Text;
            this.J = textBox10.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
