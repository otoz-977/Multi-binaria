using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multi_Binary.Admins;
using Multi_Binary.Converters;

namespace Multi_Binary.Admins
{
    class the_runner
    {

        public string timer(int T, int j)
        {
             string[] Rows = { "a", "b", "c", "d" };
              string[] Col = { "1", "2", "3", "4", "5", "6" };
             string box = Rows[T] + Col[j];

            return box;
        }
    }
}
   
