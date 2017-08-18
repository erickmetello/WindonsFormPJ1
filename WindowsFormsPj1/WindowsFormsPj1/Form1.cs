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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rapaziaaaaaadaaaaaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Eae man";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
    }