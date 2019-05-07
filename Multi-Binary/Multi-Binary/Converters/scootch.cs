using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Binary.Converters
{
    class scootch
    {
        private char[] tmp = new char[4];// for displacing Q or A
       
       
        public string slide(string x,char a)
        {
            char last = a ;//last member of A or just 0;

            tmp = x.ToCharArray();
           
            //string Q1 =newArray.Last().ToString();

            for(int i =3;i>=0;i--)
            {

                tmp[i] = i != 0 ?tmp[i - 1]: last;
            }

           

            string result = tmp.ToString();

            return result ;
        }

    }
}
