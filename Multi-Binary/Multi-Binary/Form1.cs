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

namespace Multi_Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reader t = new Reader();
           
            //calls properties of _Q and _M
            t._Mstr = Mtxt.Text;
            t._Qstr = Qtxt.Text;


            r1c2.Text = t._Qstr;
            r1c4.Text = t._Mstr;





        }
    }
}
