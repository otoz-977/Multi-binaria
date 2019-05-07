using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multi_Binary.Admins;

namespace Multi_Binary.Admins
{
    class Reader
    {
        private string _Q;  // the Q field
        private string _M;  // the N field


        Bin_conv bin = new Bin_conv();

        public string _Qstr    // the Q property
        {
            get
            {
                return _Q;
            }
            set // establece el valor de _Q, depende de si value es negativo o no;
            {
               
                string b;      
                
                //que pasa si es negativa
                if ( value.Contains("-"))//this is before conversion to binary
                {
                    _Q = bin.removeneg(value);
                    b= bin.binario(_Q);
                    _Q = bin.Comp2(b);                  
                }
                else //es normal
                {
                    _Q = bin.binario(value);
                }
                
            }
        }

        public string _Mstr    // the N property
        {
            get
            {
                return _M;
            }
            set
            {
                string b;

                //que pasa si es negativa
                if (value.Contains("-"))//this is before conversion to binary
                {
                    _M = bin.removeneg(value);
                    b = bin.binario(_M);
                    _M = bin.Comp2(b);
                }
                else //es normal
                {
                    _M = bin.binario(value);
                }
            }
        }



    }
}
