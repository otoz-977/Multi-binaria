using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multi_Binary.Admins;
using Multi_Binary.Converters;

namespace Multi_Binary
{
    public partial class Form1 : Form
    {
        string M,Q,A,Q1;

        private void r5c3_TextChanged(object sender, EventArgs e)
        {

        }

        int rows = 4, col = 4;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reader t = new Reader();
            Writer w = new Writer();
            Bin_conv b = new Bin_conv();

            t._Mstr = Mtxt.Text;
            t._Qstr = Qtxt.Text;
                    
            Q = t._Qstr;
            M = t._Mstr;
            A = "0000";
            Q1 = "0";
            r1c2.Text = t._Qstr;
            r1c4.Text = t._Mstr;

            r1c5.Text = " Valores iniciales";
            r1c6.Text = " ciclo";
            r1c1.Text = A;
            r1c3.Text = Q1;

            
            
             










        }


    }
}
