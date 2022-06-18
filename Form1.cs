
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesorki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string HexLetters = "0123456789abcdefABCDEF\b"; 



        private void randomButton_Click(object sender, EventArgs e)
        {
        Random rnd = new Random();
            axText.Text = rnd.Next(0, 65535).ToString("X");
            bxText.Text = rnd.Next(0, 65535).ToString("X");
            cxText.Text = rnd.Next(0, 65535).ToString("X");
            dxText.Text = rnd.Next(0, 65535).ToString("X");
        }

        private void xchgButton_Click(object sender, EventArgs e)
        {

            if (axFrom.Checked && bxTo.Checked)
            {
                string x = axText.Text;
                string y = bxText.Text;
                axText.Text = y;
                bxText.Text = x;
            }
            else if (axFrom.Checked && cxTo.Checked)
            {
                string x = axText.Text;
                string y = cxText.Text;
                axText.Text = y;
                cxText.Text = x;
            }
            else if (axFrom.Checked && dxTo.Checked)
            {
                string x = axText.Text;
                string y = dxText.Text;
                axText.Text = y;
                dxText.Text = x;
            }

            if (bxFrom.Checked && axTo.Checked)
            {
                string x = bxText.Text;
                string y = axText.Text;
                bxText.Text = y;
                axText.Text = x;
            }
            else if (bxFrom.Checked && cxTo.Checked)
            {
                string x = bxText.Text;
                string y = cxText.Text;
                bxText.Text = y;
                cxText.Text = x;
            }
            else if (bxFrom.Checked && dxTo.Checked)
            {
                string x = bxText.Text;
                string y = dxText.Text;
                bxText.Text = y;
                dxText.Text = x;
            }

            if (cxFrom.Checked && axTo.Checked)
            {
                string x = cxText.Text;
                string y = axText.Text;
                cxText.Text = y;
                axText.Text = x;
            }
            else if (cxFrom.Checked && bxTo.Checked)
            {
                string x = cxText.Text;
                string y = bxText.Text;
                cxText.Text = y;
                bxText.Text = x;
            }
            else if (cxFrom.Checked && dxTo.Checked)
            {
                string x = cxText.Text;
                string y = dxText.Text;
                cxText.Text = y;
                dxText.Text = x;
            }

            if (dxFrom.Checked && axTo.Checked)
            {
                string x = dxText.Text;
                string y = axText.Text;
                dxText.Text = y;
                axText.Text = x;
            }
            else if (dxFrom.Checked && bxTo.Checked)
            {
                string x = dxText.Text;
                string y = bxText.Text;
                dxText.Text = y;
                bxText.Text = x;
            }
            else if (dxFrom.Checked && cxTo.Checked)
            {
                string x = dxText.Text;
                string y = cxText.Text;
                dxText.Text = y;
                cxText.Text = x;
            }





        }


        private void moveButton_Click(object sender, EventArgs e)
        {




            if (axFrom.Checked && bxTo.Checked)        
            {
                bxText.Text = axText.Text;
            }
            else if (axFrom.Checked && cxTo.Checked)
            {
                cxText.Text = axText.Text;
            }
            else if (axFrom.Checked && dxTo.Checked)
            {
                dxText.Text = axText.Text;
            }



            if (bxFrom.Checked && axTo.Checked)    
            {
                axText.Text = bxText.Text;
            }
            else if (bxFrom.Checked && cxTo.Checked)
            {
                cxText.Text = bxText.Text;
            }
            else if (bxFrom.Checked && dxTo.Checked)
            {
                dxText.Text = bxText.Text;
            }



            if (cxFrom.Checked && axTo.Checked)       
            {
                axText.Text = cxText.Text;
            }
            else if (cxFrom.Checked && bxTo.Checked)
            {
                bxText.Text = cxText.Text;
            }
            else if (cxFrom.Checked && dxTo.Checked)
            {
                dxText.Text = cxText.Text;
            }
            

            if (dxFrom.Checked && axTo.Checked)        
            {
                axText.Text = dxText.Text;
            }
            else if (dxFrom.Checked && bxTo.Checked)
            {
                bxText.Text = dxText.Text;
            }
            else if (dxFrom.Checked && cxTo.Checked)
            {
                cxText.Text = dxText.Text;
            }
        }
        
    }
}