﻿using System;
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

        string rows, col;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reader t = new Reader();
            Writer w = new Writer();
            Bin_conv b = new Bin_conv();
            the_runner R = new the_runner();

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

         



            //separar a Q
           string temp = w.separate(Q).ToString();
           
            if(temp == Q1)
            {
               //nothing
            }
            else
            {
                if(temp == "1")
                {
                    //restando
                    M= b.Comp2(M);
                    A=w.adding(M, A);
                }
                else
                {
                    //sumando
                    A= w.adding(M, A);
                }
            }
            char timp =w.separate(A);
            w.slide(A, '0');

            char qone =w.separate(Q);
            w.slide(A, timp);

            Q1 = qone.ToString();



            /*
            
            for(int T =1; T<=4;T++)
            {
                for(int j =1;j<=6;j++)
                {
                    string name =R.timer(T, j);
                    RichTextBox txtBox = (RichTextBox)this.Controls.Find(name, true)[0];

                    txtBox.Text = j == 1 ? A : j == 2 ? Q : j == 3 ? Q1 : j == 4 ? M : j == 5 ? "(+/-)" : "";


                }
                



            }
            */
           
            
             










        }


    }
}
