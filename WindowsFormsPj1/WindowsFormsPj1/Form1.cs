using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPj1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string cu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Oi , Edlaine da o cu!!\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cu = rand.Next(trackBar1.Value).ToString();
            //textBox1.Text = "è vdd ela é muita dadeira!!";
            //textBox1.AppendText("\n");
            textBox1.AppendText(" puta que pariu,ela é uma puta mesmo!! " + cu + "\n");
            

            if (checkBox1.Enabled == true)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
            

            label1.Text = cu;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        
    }
}