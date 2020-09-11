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
    public partial class Form8 : Form
    {
        
        public string pvalue2;
        public string pvalue3;
        public string pvalue4;
        public string pvalue5;
        public string pvalue6;
        public string pvalue7;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           
            this.pvalue2 = textBox2.Text;
            this.pvalue3 = textBox3.Text;
            this.pvalue4 = textBox4.Text;
            this.pvalue5 = textBox5.Text;
            this.pvalue6 = textBox6.Text;
            this.pvalue7 = textBox7.Text;
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                
                this.pvalue2 = textBox2.Text;
                this.pvalue3 = textBox3.Text;
                this.pvalue4 = textBox4.Text;
                this.pvalue5 = textBox5.Text;
                this.pvalue6 = textBox6.Text;
                this.pvalue7 = textBox7.Text;
                this.Close();

            }
            else
            {
                MessageBox.Show("enter all fields!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
