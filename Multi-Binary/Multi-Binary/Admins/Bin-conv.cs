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
        private string str2;
        private char[] arr;


        //con vierte un numero en forma string ( 0-15) a una serie de binarios;
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

        //despues de ser convertido en binario, este metodo lo transforma en complemento2;
        public string Comp2 (string valor)
        {
            char[] charArr = valor.ToCharArray();
            Array.Reverse(charArr);
            bool convert = false;                   
            for(int i = 0; i < charArr.Length; i++)
            {
                           
                if (convert ==true)
                {
                    switch(charArr[i])
                    {
                        case '1':
                            charArr[i] = '0';
                            break;
                        case '0':
                            charArr[i] = '1';
                            break;
                    }
                    
                }
                if (charArr[i] == '1'  )
                {
                    convert = true;             
                }
            }
            Array.Reverse(charArr);
            str2 = new string(charArr);
            return str2;           
        }

        //elimina el " - " de un numero, para usarlo en binario()
        public string removeneg(string value)
        {
            string Value;
            Value =value.Trim('-');
            return Value;
        }              
    }
}
