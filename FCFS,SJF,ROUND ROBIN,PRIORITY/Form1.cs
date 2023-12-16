using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS_SJF_ROUND_ROBIN_PRIORITY
{
    public partial class Form1 : Form
    {
        ArrayList array = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            P1.Text = "";
            P2.Text = "";
            P3.Text = "";
            P4.Text = "";
            txt_Q.Text = txt_P1.Text = txt_P2.Text = txt_P3.Text = txt_P4.Text = "";
            MessageBox.Show("Operation IS Finished ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            array.Add(Convert.ToInt32(txt_P1.Text));
            array.Add(Convert.ToInt32(txt_P2.Text));
            array.Add(Convert.ToInt32(txt_P3.Text));
            array.Add(Convert.ToInt32(txt_P4.Text));
            foreach (var item in array)
            {
                checkedListBox1_RAM.Items.Add(item);
            }
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            array.Add(Convert.ToInt32(txt_P1.Text));
            array.Add(Convert.ToInt32(txt_P2.Text));
            array.Add(Convert.ToInt32(txt_P3.Text));
            array.Add(Convert.ToInt32(txt_P4.Text));
            array.Sort();
            foreach (var item in array)
            {
                checkedListBox1_RAM.Items.Add(item);
            }
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkedListBox1_RAM.Items.Count == 0)
            {
                return;
            }

            timer1.Interval = Convert.ToInt32(checkedListBox1_RAM.Items[0] + "000");
            if (checkedListBox1_RAM.Items[0].ToString() == txt_P1.Text)
            {
                txt_CPU.Text = label1.Text;
            }
            else if (checkedListBox1_RAM.Items[0].ToString() == txt_P2.Text)
            {
                txt_CPU.Text = label2.Text;
            }
            else if (checkedListBox1_RAM.Items[0].ToString() == txt_P3.Text)
            {
                txt_CPU.Text = label3.Text;
            }
            else if (checkedListBox1_RAM.Items[0].ToString() == txt_P4.Text)
            {
                txt_CPU.Text = label4.Text;
            }
            checkedListBox1_RAM.Items.RemoveAt(0);

            if (checkedListBox1_RAM.Items.Count <= 0)
            {
                MessageBox.Show("Processor is Idel and Wait the processes !!");
                timer1.Stop();
                array.Clear();

            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            P1.Text = txt_P1.Text;
            P2.Text = txt_P2.Text;
            P3.Text = txt_P3.Text;
            P4.Text = txt_P4.Text;
            timer2.Start();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            if (txt_P1.Text != "" && txt_P2.Text != "" && txt_P3.Text != "" && txt_P4.Text != "" && txt_Q.Text != "")
            {
                if (Convert.ToInt16(txt_P1.Text) > 0)
                {
                    if (Convert.ToInt16(txt_P1.Text) >= Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P1.Text = (Convert.ToInt16(txt_P1.Text) - Convert.ToInt16(txt_Q.Text)).ToString();
                        checkedListBox1_RAM.Items.Add(label1.Text);
                    }
                    else if (Convert.ToInt16(txt_P1.Text) < Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P1.Text = "0";
                        checkedListBox1_RAM.Items.Add(label1.Text);
                    }
                }
                if (Convert.ToInt16(txt_P2.Text) > 0)
                {
                    if (Convert.ToInt16(txt_P2.Text) >= Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P2.Text = (Convert.ToInt16(txt_P2.Text) - Convert.ToInt16(txt_Q.Text)).ToString();
                        checkedListBox1_RAM.Items.Add(label2.Text);
                    }
                    else if (Convert.ToInt16(txt_P2.Text) < Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P2.Text = "0";
                        checkedListBox1_RAM.Items.Add(label2.Text);
                    }
                }
                if (Convert.ToInt16(txt_P3.Text) > 0)
                {
                    if (Convert.ToInt16(txt_P3.Text) >= Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P3.Text = (Convert.ToInt16(txt_P3.Text) - Convert.ToInt16(txt_Q.Text)).ToString();
                        checkedListBox1_RAM.Items.Add(label3.Text);
                    }
                    else if (Convert.ToInt16(txt_P3.Text) < Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P3.Text = "0";
                        checkedListBox1_RAM.Items.Add(label3.Text);
                    }
                }
                if (Convert.ToInt16(txt_P4.Text) > 0)
                {
                    if (Convert.ToInt16(txt_P4.Text) >= Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P4.Text = (Convert.ToInt16(txt_P4.Text) - Convert.ToInt16(txt_Q.Text)).ToString();
                        checkedListBox1_RAM.Items.Add(label4.Text);
                    }
                    else if (Convert.ToInt16(txt_P4.Text) < Convert.ToInt16(txt_Q.Text))
                    {
                        txt_P4.Text = "0";
                        checkedListBox1_RAM.Items.Add(label4.Text);
                    }
                }
                timer2.Stop();
                txt_CPU.Text = "";
                timer3.Start();
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("You should Inter Values First");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (checkedListBox1_RAM.Items.Count > 0)
            {
                txt_CPU.Text = checkedListBox1_RAM.Items[0].ToString();
                checkedListBox1_RAM.Items.RemoveAt(0);
                timer3.Stop();
                timer2.Start();
            }
            else if (checkedListBox1_RAM.Items.Count <= 0)
            {
                timer3.Stop();
                //clear();
             
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            array.Add(Convert.ToInt32(Priority_P1.Text));
            array.Add(Convert.ToInt32(Priority_P2.Text));
            array.Add(Convert.ToInt32(Priority_P3.Text));
            array.Add(Convert.ToInt32(Priority_P4.Text));
            array.Sort();
            foreach (var item in array)
            {
                checkedListBox1_RAM.Items.Add(item);
            }
            timer4.Start();
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            if (checkedListBox1_RAM.Items.Count == 0)
            {
                return;
            }

            if (checkedListBox1_RAM.Items[0].ToString() == Priority_P1.Text)
            {
                timer4.Interval = Convert.ToInt32(txt_P1.Text + "000");
                txt_CPU.Text = label1.Text;
            }
            else if (checkedListBox1_RAM.Items[0].ToString() == Priority_P2.Text)
            {
                timer4.Interval = Convert.ToInt32(txt_P2.Text + "000");
                txt_CPU.Text = label2.Text;
            }
            else if (checkedListBox1_RAM.Items[0].ToString() == Priority_P3.Text)
            {
                timer4.Interval = Convert.ToInt32(txt_P3.Text + "000");
                txt_CPU.Text = label3.Text;
            }
            else if (checkedListBox1_RAM.Items[0].ToString() == Priority_P4.Text)
            {
                timer4.Interval = Convert.ToInt32(txt_P4.Text + "000");
                txt_CPU.Text = label4.Text;
            }
            checkedListBox1_RAM.Items.RemoveAt(0);

            if (checkedListBox1_RAM.Items.Count <= 0)
            {
                MessageBox.Show("Processor is Idel and Wait the processes !!");
                timer4.Stop();

            }
        }

        
    }
}
