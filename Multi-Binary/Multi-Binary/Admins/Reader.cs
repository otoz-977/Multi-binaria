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
            set
            {
               _Q = bin.binario(value);
                if( _Q.Contains("-"))
                {
                    _Q = bin.bin-comp2(value);
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
                _M = bin.binario(value);
            }
        }



    }
}
