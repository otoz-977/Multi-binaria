using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "0101";
            string b = "1001";
            char a ='0';

            schooch tr = new schooch();

            string mate = tr.slide(A, a);

            Console.WriteLine(A);
            Console.WriteLine(mate);
            Console.Read();

        }


        public class schooch
        {
            private char[] tmp = new char[4];// 0101
            private char[] gg = new char[4];//-010-


            public string slide(string x, char a)
            {
                char last = a;//last member of A or just 0;

                 tmp = x.ToCharArray();


               
                for (int i = 0; i <3; i++)
                {
                    gg[i+1] = tmp[i];   
                    
                    
                }
                gg[0] = a;



                string result = new string(gg);

                return result;
            }


            
        }


    }
}
