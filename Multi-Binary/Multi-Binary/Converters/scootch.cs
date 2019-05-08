using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Binary.Converters
{
    class scootch
    {
        private char[] tmp = new char[4];// 0101
        private char[] gg = new char[4];//-010-


        public string slide(string x, char a)
        {
            char last = a;//last member of A or just 0;

            tmp = x.ToCharArray();



            for (int i = 0; i < 3; i++)
            {
                gg[i + 1] = tmp[i];


            }
            gg[0] = a;



            string result = new string(gg);

            return result;
        }
    }

    
}
