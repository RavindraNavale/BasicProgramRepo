using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Parent
    {
        public void tt()
        {
            Console.WriteLine("method parent");
            Console.ReadLine();
        }
    }

    public class child : Parent
    {
        public void  tt()
        {
            Console.WriteLine("method child");
            Console.ReadLine();
        }

    }
}
