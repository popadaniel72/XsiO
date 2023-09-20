using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XsiO
{
    public partial class Form1 : Form
    {
        int cine;
        int[] c1;
        int[] c2;
        int[] c3;
        int[] l1;
        int[] l2;
        int[] l3;
        int[] dp;
        int[] ds;
     

        private void b13_Click(object sender, EventArgs e)
        {
            if (b13.Text == "")
            {
                if (cine == 1) b13.Text = "X";
                else b13.Text = "O";

                c3[cine]++; l1[cine]++; ds[cine]++;
                if (c1[cine] == 3 || l1[cine] == 3 || ds[cine] == 3)
                    if (cine == 1) MessageBox.Show("X a castigat");
                    else MessageBox.Show("0 a castigat");
                cine = 1 - cine;
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.Text == "")
            {
                if (cine == 1) b12.Text = "X";
                else b12.Text = "O";

                c2[cine]++; l1[cine]++;
                if (c2[cine] == 3 || l1[cine] == 3)
                    if (cine == 1) MessageBox.Show("X a castigat");
                    else MessageBox.Show("0 a castigat");
                cine = 1 - cine;
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if(b11.Text == "")
            {
                if (cine == 1) b11.Text = "X";
                else b11.Text = "O";
                
                c1[cine]++; l1[cine]++; dp[cine]++;
                if (c1[cine] == 3 || l1[cine] == 3 || dp[cine] == 3)
                    if (cine == 1) MessageBox.Show("X a castigat");
                    else MessageBox.Show("0 a castigat");
                cine = 1 - cine;
            }
        }

        public Form1()
        {
            InitializeComponent();
            cine = 1; /// 1=x, 0 = 0
            c1 = new int[2]; c2 = new int[2]; c3 = new int[2];
            l1 = new int[2]; l2 = new int[2]; l3 = new int[2];
            ds = new int[2]; dp = new int[2]; 
            c1[0] = c2[0] = c3[0] = l1[0] = l2[0] = l3[0] = ds[0] = dp[0] = 0;
            b11.Text = ""; b12.Text = ""; b13.Text = "";
            b21.Text = ""; b22.Text = ""; b23.Text = "";
            b31.Text = ""; b32.Text = ""; b33.Text = ""; 
        }

        private void reset_Click(object sender, EventArgs e)
        {
            cine = 1;
            c1 = new int[2]; c2 = new int[2]; c3 = new int[2];
            l1 = new int[2]; l2 = new int[2]; l3 = new int[2];
            ds = new int[2]; dp = new int[2];
            b11.Text = ""; b12.Text = ""; b13.Text = "";
            b21.Text = ""; b22.Text = ""; b23.Text = "";
            b31.Text = ""; b32.Text = ""; b33.Text = "";
        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (b21.Text == "")
            {
                if (cine == 1) b21.Text = "X";
                else b21.Text = "O";

                c1[cine]++; l2[cine]++; 
                if (c2[cine] == 3 || l1[cine] == 3)
                    if (cine == 1) MessageBox.Show("X a castigat");
                    else MessageBox.Show("0 a castigat");
                cine = 1 - cine;
            }
        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (b11.Text == "")
            {
                if (cine == 1) b11.Text = "X";
                else b11.Text = "O";

                c1[cine]++; l1[cine]++; dp[cine]++;
                if (c1[cine] == 3 || l1[cine] == 3 || dp[cine] == 3)
                    if (cine == 1) MessageBox.Show("X a castigat");
                    else MessageBox.Show("0 a castigat");
                cine = 1 - cine;
            }
        }
    }
}
