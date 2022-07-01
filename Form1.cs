using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week14_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FontFamily family;
        FontStyle style;

        private void lstCOLOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstCOLOR.SelectedIndex)
            {
                case 0:
                    label1.ForeColor = Color.Black;
                    break;
                case 1:
                    label1.ForeColor = Color.Red;
                    break;
                case 2:
                    label1.ForeColor = Color.Yellow;
                    break;
                case 3:
                    label1.ForeColor = Color.Green;
                    break;
                case 4:
                    label1.ForeColor = Color.Blue;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboCHAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            family = new FontFamily(cboCHAR.Text);
            label1.Font = new Font(family, 14,style);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colorlist = { "黑色", "紅色", "藍色", "黃色", "綠色" };
            lstCOLOR.Items.AddRange(colorlist);
            lstCOLOR.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label1_FontChanged(object sender, EventArgs e)
        {

        }

        private void rdbITALIC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbITALIC.Checked)
                style = FontStyle.Italic;
            label1.Font = new Font(Font, style);
        }

        private void rdbBOLD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBOLD.Checked)
                style = FontStyle.Bold;
            label1.Font = new Font(Font, style);
        }

        private void rdbUNDERLINE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUNDERLINE.Checked)
                style = FontStyle.Underline;
            label1.Font = new Font(Font, style); 
        }

        private void rdbNORMAL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNORMAL.Checked)
                style = FontStyle.Regular;
            label1.Font = new Font(Font, style); ;
        }
    }
}





