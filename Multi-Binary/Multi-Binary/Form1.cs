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
using System.Data.SqlClient;

namespace Multi_Binary
{
    public partial class Form1 : Form
    {
       

        private void r5c3_TextChanged(object sender, EventArgs e)
        {

        }

        private void c1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Qtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          



        }

        public Form1()
        {
            InitializeComponent();
        }

        string M, Q, A, Q1;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\\Users\\user\\Source\\Repos\\Multi-binaria\\Multi-Binary\\Multi-Binary\\bin\\NIGHT.wav");

            //sp.PlayLooping();

            sp.Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Reader t = new Reader();
            Writer w = new Writer();
            Bin_conv b = new Bin_conv();
            //the_runner R = new the_runner();

            //set the binaries;
            t._Mstr = Mtxt.Text;
            t._Qstr = Qtxt.Text;
            //gets them an assigns them to the variabels
            Q = t._Qstr;
            M = t._Mstr;
            A = "0000";
            Q1 = "0";
            
            r1c1.Text = A;
            r1c2.Text = t._Qstr;
            r1c3.Text = Q1;
            r1c4.Text = t._Mstr;
            r1c5.Text = " Valores iniciales";
            r1c6.Text = " ciclo";

            c16.Text = M;
            c14.Text = M;
            
            c15.Text = M;
            c13.Text = M;

            string tmp,Mtmp;
            char Atmp;
            string[] pr = { " sin +/-", "desp","+","-"};
            


            //1o
            tmp = w.separate(Q).ToString();
            
            c9.Text = Q1;
            if(tmp == Q1)
            {
                c17.Text = pr[0];
            }
            else
            {
                if(tmp =="1")
                {
                    Mtmp = b.Comp2(M);
                    A = w.adding(A, Mtmp);
                    c17.Text = pr[3];
                }
                else
                {
                    A = w.adding(A, M);
                    c17.Text = pr[2];
                }
            }
            c1.Text = A;
            Atmp = w.separate(A);
            A = w.slide(A, '0');
            c1.Text += Environment.NewLine + A;
            c5.Text = Q;
            Q = w.slide(Q, Atmp);
            c5.Text += Environment.NewLine + Q;
            Q1 = tmp;
            c9.Text += Environment.NewLine + Q1;
            c17.Text += Environment.NewLine + pr[1];
            c21.Text = " 1o";

            //2o
            tmp = w.separate(Q).ToString();

            c10.Text = Q1;
            if (tmp == Q1)
            {
                c18.Text = pr[0];
            }
            else
            {
                if (tmp == "1")
                {
                    Mtmp = b.Comp2(M);
                    A = w.adding(A, Mtmp);
                    c18.Text = pr[3];
                }
                else
                {
                    A = w.adding(A, M);
                    c18.Text = pr[2];
                }
            }
            c2.Text = A;
            Atmp = w.separate(A);
            A = w.slide(A, '0');
            c2.Text += Environment.NewLine + A;
            c6.Text = Q;
            Q = w.slide(Q, Atmp);
            c6.Text += Environment.NewLine + Q;
            Q1 = tmp;
            c10.Text += Environment.NewLine + Q1;
            c18.Text += Environment.NewLine + pr[1];
            c22.Text = " 2o";
            //3er
            tmp = w.separate(Q).ToString();

            c11.Text = Q1;
            if (tmp == Q1)
            {
                c19.Text = pr[0];
            }
            else
            {
                if (tmp == "1")
                {
                    Mtmp = b.Comp2(M);
                    A = w.adding(A, Mtmp);
                    c19.Text = pr[3];
                }
                else
                {
                    A = w.adding(A, M);
                    c19.Text = pr[2];
                }
            }
            c3.Text = A;
            Atmp = w.separate(A);
            A = w.slide(A, '0');
            c3.Text += Environment.NewLine + A;
            c7.Text = Q;
            Q = w.slide(Q, Atmp);
            c7.Text += Environment.NewLine + Q;
            Q1 = tmp;
            c11.Text += Environment.NewLine + Q1;
            c19.Text += Environment.NewLine + pr[1];
            c23.Text = " 3er";
            //4o
            tmp = w.separate(Q).ToString();

            c12.Text = Q1;
            if (tmp == Q1)
            {
                c20.Text = pr[0];
            }
            else
            {
                if (tmp == "1")
                {
                    Mtmp = b.Comp2(M);
                    A = w.adding(A, Mtmp);
                    c20.Text = pr[3];
                }
                else
                {
                    A = w.adding(A, M);
                    c20.Text = pr[2];
                }
            }
            c4.Text = A;
            Atmp = w.separate(A);
            A = w.slide(A, '0');
            c4.Text += Environment.NewLine + A;
            c8.Text = Q;
            Q = w.slide(Q, Atmp);
            c8.Text += Environment.NewLine + Q;
            Q1 = tmp;
            c12.Text += Environment.NewLine + Q1;
            c20.Text += Environment.NewLine + pr[1];
            c24.Text = " 4o";








        }



        


    }
            













}




