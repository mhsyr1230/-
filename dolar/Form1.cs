using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolar
{
    public partial class Form1 : Form
    {int dol=2100;
        int tr = 300;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>='0'&&e.KeyChar<='9')
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            comboBox1.Items.Add("$");
            comboBox1.Items.Add("sy");
            comboBox1.Items.Add("tl");
            comboBox2.Items.Add("$");
            comboBox2.Items.Add("sy");
            comboBox2.Items.Add("tl");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (comboBox1.SelectedItem == "$" & comboBox2.SelectedItem=="sy")
          {
              int n = Convert.ToInt32(textBox1.Text);
               double r = n * dol;
               label3.Text = Convert.ToString(r);
          }
           else if (comboBox1.SelectedItem == "sy" & comboBox2.SelectedItem == "$")
                {
                    int n = Convert.ToInt32(textBox1.Text);
                    double r = n / dol;
                    label3.Text = Convert.ToString(r+"$");
                }
            else if (comboBox1.SelectedItem == "tl" & comboBox2.SelectedItem == "sy")
            {
                int n = Convert.ToInt32(textBox1.Text);
                double r = n * tr;
                label3.Text = Convert.ToString(r);
            }
            else if (comboBox1.SelectedItem == "sy" & comboBox2.SelectedItem == "tl")
            {
                float n = Convert.ToInt32(textBox1.Text);
                float r = n / tr;
                label3.Text = Convert.ToString(r);
            }
            else if (comboBox1.SelectedItem == "tl" & comboBox2.SelectedItem == "$")
            {
                float n = Convert.ToInt32(textBox1.Text);
                float t = 7.40f;
                float r = n /t;
                label3.Text = Convert.ToString(r);
            }
            else if (comboBox1.SelectedItem == "$" & comboBox2.SelectedItem == "tl")
            {
                float n = Convert.ToInt32(textBox1.Text);
                float t = 7.40f;
                float r = n * t;
                label3.Text = Convert.ToString(r);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
