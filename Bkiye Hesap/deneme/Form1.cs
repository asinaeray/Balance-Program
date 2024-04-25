using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double bakiye = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void odeme_Click(object sender, EventArgs e)
        {
            if (bakiye<=0)
            {
                MessageBox.Show("Paranız yok");
            }
            else
            {
                if (ib.Checked)
                {
                    bakiye -= 17.70;
                }
                else if (og.Checked)
                {
                    bakiye -= 8.20;
                }
                else
                {
                    MessageBox.Show("seçim yapınız");
                }
                para.Text = bakiye.ToString();
            }
            
        }

        private void y50_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            para.Text = bakiye.ToString();
        }

        private void y100_Click(object sender, EventArgs e)
        {
            bakiye += 100;
            para.Text = bakiye.ToString();
        }

        private void y200_Click(object sender, EventArgs e)
        {
            bakiye += 200;
            para.Text = bakiye.ToString();
        }
    }
}
