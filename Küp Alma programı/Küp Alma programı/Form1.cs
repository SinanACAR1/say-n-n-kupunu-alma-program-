using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Küp_Alma_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double küp;

            küp = Convert.ToDouble(textBox1.Text);

            küp = küp * küp * küp;
            label2.Text = küp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
