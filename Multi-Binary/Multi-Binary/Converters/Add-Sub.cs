using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multi_Binary.Admins;

namespace Multi_Binary.Converters
{
    class Add_Sub
    {
        public  string addBinary(string a,
                            string b)
        {

            // Initialize result
            string result = "";

            // Initialize digit sum
            int s = 0;

            // Travers both strings starting  
            // from last characters
            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {

                // Comput sum of last  
                // digits and carry
                s += ((i >= 0) ? a[i] - '0' : 0);
                s += ((j >= 0) ? b[j] - '0' : 0);

                // If current digit sum is  
                // 1 or 3, add 1 to result
                result = (char)(s % 2 + '0') + result;

                // Compute carry
                s /= 2;

                // Move to next digits
                i--; j--;
            }


            char[] check = result.ToCharArray();

            char[] tmp = new char[4];
            if(check.Length >=5)
            {


                Array.Copy(check, 1, tmp, 0, tmp.Length);

               
                result = new string(tmp);
            }


            return result;
        }
    }
}
