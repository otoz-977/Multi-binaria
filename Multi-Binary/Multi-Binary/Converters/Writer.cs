using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multi_Binary.Admins;
using Multi_Binary.Converters;
using System.IO;

namespace Multi_Binary.Converters
{
    class Writer//this class is the calculator of the entire app
    {
        Add_Sub add = new Add_Sub();
        scootch sc = new scootch();
        Sept se = new Sept();
        Bin_conv b = new Bin_conv();

        //enter a binary and conert into comp2
        public string comp2(string a)
        {
            string results;
            results = b.Comp2(a);

            return results;
        }



        // adds, use along with converter for subtraction;
        public string adding(string a,string b)
        {
            string results;
            results =add.addBinary(a,b);

            return results;
        }

        //Seprates the last string, usefull
        public char separate(string a)
        {
            char results;
            results = se.lastmem(a);

            return results;
        }


        //slide the strings; A or Q
        public string slide(string q,char a)
        {
            string rays;
            rays = sc.slide(q , a);


            return rays;
        }
        /*
        public void makefile()
        {

            string filename = @"C:\\Users\\user\\Source\\Repos\\Multi-binaria\\Multi-Binary\\Multi-Binary\\bin\\Table.txt";

            List<string> lines = new List<string>();
            lines.Add(A);



        }
        */






    }
}
