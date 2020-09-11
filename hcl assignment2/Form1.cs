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
    public partial class Form1 : Form
    {
        public string value1;
        public string value2;
        public string value3;
        public string value4;
        public string value5;
        public static string l1;

        public static string l2; public static string l3; public static string l4; public static string l5;
        public static string l6; public static string l7; public static string l8; public static string l9;
        public static string l10;public static string l11;

      

        public Form1()
        {

            InitializeComponent();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form3 f = new Form3();
            f.ShowDialog();
            if (f.setValue1 != "" && f.setValue2 != "" && f.setValue3 != "" && f.setValue4 != "" && f.setValue5 != "")
            {
                ListViewItem list = new ListViewItem();
                list.Text = f.setValue1;
                list.SubItems.Add(f.setValue2);
                list.SubItems.Add(f.setValue3);
                list.SubItems.Add(f.setValue4);
                list.SubItems.Add(f.setValue5);
                listView1.Items.Add(list);
                MessageBox.Show("new customer added");
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            label9.Text = item.SubItems[0].Text;
            label10.Text = item.SubItems[4].Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            listView1.SelectedItems[0].Remove();
            MessageBox.Show("deleted!");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (listView1.SelectedItems.Count != 0)
            {
              
                Form4 f = new Form4();
                f.ShowDialog();

                if (f.value1 != "" && f.value2 != "" && f.value3 != "" && f.value4 != "" && f.value5 != "")
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    item.SubItems[0].Text = f.value1;
                    item.SubItems[1].Text = f.value2;
                    item.SubItems[2].Text = f.value3;
                    item.SubItems[3].Text = f.value4;
                    item.SubItems[4].Text = f.value5;
                    MessageBox.Show("update customer successfully");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
            if (f.field1 != "" && f.field2 != "" && f.field3 != "" && f.field4 != "" && f.field5 != "" && f.field6 != "" && f.field6 != "")
            {
                ListViewItem list = new ListViewItem();
                list.Text = f.field1;
                list.SubItems.Add(f.field2);
                list.SubItems.Add(f.field3);
                list.SubItems.Add(f.field4);
                list.SubItems.Add(f.field5);
                list.SubItems.Add(f.field6);
                list.SubItems.Add(f.field7);
                listView2.Items.Add(list);
                MessageBox.Show("new property added!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listView2.SelectedItems.Count == 0)
                return;

            listView2.SelectedItems[0].Remove();
            MessageBox.Show("property deleted!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 0)
            {
                Form6 f = new Form6();
                f.ShowDialog();
                if (f.updateValue1 != "" && f.updateValue2 != "" && f.updateValue3 != "" && f.updateValue4 != "" && f.updateValue5 != "" && f.updateValue6 != "" && f.updateValue7 != "")
                {
                    ListViewItem item = listView2.SelectedItems[0];
                    item.SubItems[0].Text = f.updateValue1;
                    item.SubItems[1].Text = f.updateValue2;
                    item.SubItems[2].Text = f.updateValue3;
                    item.SubItems[3].Text = f.updateValue4;
                    item.SubItems[4].Text = f.updateValue5;
                    item.SubItems[5].Text = f.updateValue6;
                    item.SubItems[6].Text = f.updateValue7;
                    MessageBox.Show("property updated!");
                }
            }
        }
    
        private void tabPage2_Click(object sender, EventArgs e)
        {

        } 

        private void button8_Click(object sender, EventArgs e)
        {
            int tabIndex = tabControl1.SelectedIndex;
            if (tabIndex > 0) {
                tabIndex = tabIndex - 1;
                tabControl1.SelectedIndex = tabIndex;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int tabIndex = tabControl1.SelectedIndex;
            if (tabIndex < 3)
            {        tabIndex = tabIndex + 1;
                tabControl1.SelectedIndex = tabIndex;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dateTimePicker1.Text;
            item.SubItems.Add(dateTimePicker2.Text);
            item.SubItems.Add(dateTimePicker3.Text);
            listView3.Items.Add(item);
            string message = "appointment booked on" + dateTimePicker2.Text + " On " + dateTimePicker1.Text;

            MessageBox.Show(message);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)     
                return;
            ListViewItem item = listView3.SelectedItems[0];
            dateTimePicker1.Text = item.SubItems[1].Text;
            dateTimePicker2.Text = item.SubItems[2].Text;
            dateTimePicker3.Text = item.SubItems[3].Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
                return; 

                listView3.SelectedItems[0].Remove();
            MessageBox.Show("appointment delete!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0) 
                    return; 

            ListViewItem item = listView3.SelectedItems[0];
            item.SubItems[0].Text = dateTimePicker1.Text;
            item.SubItems[1].Text = dateTimePicker2.Text;
            item.SubItems[2].Text = dateTimePicker3.Text;
            MessageBox.Show("appointment updated!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            Form7 f = new Form7();
            f.ShowDialog();
            if (f.fvalue1 != "" && f.fvalue2 != "" && f.fvalue3 != "" && f.fvalue4 != "" && f.fvalue5 != "" && f.fvalue6 != "" && f.fvalue7 != "" ) {
                ListViewItem l = new ListViewItem();
                l.Text = f.fvalue1;
                l.SubItems.Add(f.fvalue2);
                l.SubItems.Add(f.fvalue3);
                l.SubItems.Add(f.fvalue4);
                l.SubItems.Add(f.fvalue5);
                l.SubItems.Add(f.fvalue6);
                l.SubItems.Add(f.fvalue7);
                listView4.Items.Add(l);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (listView4.SelectedItems.Count == 0)

            return;
            ListViewItem l2 = new ListViewItem();
            l2.Text = listView5.Items[listView4.SelectedItems[0].Index].Text;
            l2.SubItems.Add(listView5.Items[listView4.SelectedItems[0].Index].SubItems[1].Text);
            l2.SubItems.Add(listView5.Items[listView4.SelectedItems[0].Index].SubItems[5].Text);
            l2.SubItems.Add(listView5.Items[listView4.SelectedItems[0].Index].SubItems[6].Text);
            l2.SubItems.Add(listView5.Items[listView4.SelectedItems[0].Index].SubItems[7].Text);
            l2.SubItems.Add(listView5.Items[listView4.SelectedItems[0].Index].SubItems[8].Text);
            l2.SubItems.Add(listView5.Items[listView4.SelectedItems[0].Index].SubItems[9].Text);
            listView2.Items.Add(l2);
            listView5.Items[listView4.SelectedItems[0].Index].Remove();
            listView4.SelectedItems[0].Remove();
            MessageBox.Show("contract deleted!");
          



        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (listView4.SelectedItems.Count != 0)
            {
                Form8 f = new Form8();
            f.ShowDialog();
            if ( f.pvalue2 !="" && f.pvalue3 != "" && f.pvalue4 != "" && f.pvalue5 != "" && f.pvalue6 != "")
            {
              
                   
                    ListViewItem item = listView4.SelectedItems[0];           
                    item.SubItems[1].Text = f.pvalue2;
                    item.SubItems[2].Text = f.pvalue3;
                    item.SubItems[3].Text = f.pvalue4;
                    item.SubItems[4].Text = f.pvalue5;
                    item.SubItems[5].Text = f.pvalue6;
                    item.SubItems[6].Text = f.pvalue7;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
         

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem l = listView2.SelectedItems[0];
            label12.Text = l.SubItems[0].Text;
           
          
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 0)
            {
                
                ListViewItem l = listView2.SelectedItems[0];              
                Form9 f = new Form9();
                f.ShowDialog();
           
                if (f.A !="" &&f.B != "" && f.C != "" && f.D != "" && f.E!="" &&f.F!="" &&f.G!="" &&f.H!="" && f.I!= "" && f.J!="")
                {
                    ListViewItem l5 = new ListViewItem();
                    l5.Text = f.A;
                    l5.SubItems.Add(l.SubItems[1].Text);
                    l5.SubItems.Add(f.B);
                    l5.SubItems.Add(f.C);
                    l5.SubItems.Add(f.D);
                    l5.SubItems.Add(l.SubItems[2].Text);
                    l5.SubItems.Add(l.SubItems[3].Text);
                    l5.SubItems.Add(l.SubItems[4].Text);
                    l5.SubItems.Add(l.SubItems[5].Text);
                    l5.SubItems.Add(l.SubItems[6].Text);
                    listView5.Items.Add(l5);
                    listView2.SelectedItems[0].Remove();


                    ListViewItem l4 = new ListViewItem();
                    l4.Text = f.D;
                    l4.SubItems.Add(f.E);
                    l4.SubItems.Add(f.F);
                    l4.SubItems.Add(f.G);
                    l4.SubItems.Add(f.H);
                    l4.SubItems.Add(f.I);
                    l4.SubItems.Add(f.J);
                    listView4.Items.Add(l4);
                    MessageBox.Show("new contract added!");
                }
            }

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView5.SelectedItems.Count != 0)
            {


                ListViewItem l = listView5.SelectedItems[0];
                l1 = l.SubItems[0].Text;
                l2 = l.SubItems[2].Text;
                l3 = l.SubItems[3].Text;

                l4 = l.SubItems[4].Text;
                l5 = l.SubItems[5].Text;
                l6 = l.SubItems[6].Text;
                l7 = l.SubItems[7].Text;
                l8 = l.SubItems[8].Text;
                l9 = l.SubItems[9].Text;

                l10 = listView4.Items[listView5.SelectedItems[0].Index].SubItems[1].Text;
                l11 = listView4.Items[listView5.SelectedItems[0].Index].SubItems[2].Text;
                Form10 f = new Form10();

                f.ShowDialog();

            }

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void visitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void rentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;
        }

        private void lighblueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.LightBlue;
        }

        private void listView4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count != 0)
            {


                ListViewItem l = listView5.Items[listView4.SelectedItems[0].Index];
                l1 = l.SubItems[0].Text;
                l2= l.SubItems[2].Text;
                l3 =l.SubItems[3].Text;
           
                l4 = l.SubItems[4].Text;
                l5 = l.SubItems[5].Text;
                l6 = l.SubItems[6].Text;
                l7 = l.SubItems[7].Text;
                l8 = l.SubItems[8].Text;
                l9 = l.SubItems[9].Text;
                l10 = listView4.SelectedItems[0].SubItems[1].Text;
                l11= listView4.SelectedItems[0].SubItems[2].Text;
                Form10 f = new Form10();

                f.ShowDialog();

            }


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
    }
    
