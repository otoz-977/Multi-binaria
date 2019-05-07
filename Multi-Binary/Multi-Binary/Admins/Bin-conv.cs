using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Binary.Admins
{
    class Bin_conv
    {
        private string str;
        private char[] arr;
        public string binario(string value)
        {

            int nNum;
            string sNum;
            int[] iBits = new int[4];
            int[] C = { 1, 2, 4, 8 };
            sNum = value;
            nNum = Int32.Parse(sNum);
            for (int i = 3; i >= 0; i--)
            {
                if (nNum >= C[i])
                {
                    nNum = nNum - C[i];
                    iBits[i] = 1;
                }
                else
                {
                    iBits[i] = 0;
                }
            }
            string result = string.Join("", iBits);
            arr = result.ToCharArray();
            Array.Reverse(arr);
            str = new string(arr);
            return str;
        }   

        public string binario-comp2(string loe)
        {

            return loe;
            
        }
        
        



    }
}
