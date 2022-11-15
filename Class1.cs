using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Class1 : Class3,Interface1
    {
        public override void fun()
        {
            Console.WriteLine("Morning Evening");
        }

        public  void  show()
        {
            Console.WriteLine("Night");
        }

        public override void show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
