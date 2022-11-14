using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Animal
    {
        abstract string name;//abstract varibale cannot create in class
        public abstract void sound();

       public void fun()
        {
            Console.WriteLine("ddasdadada");
        }

        protected void voice()
        {
            Console.WriteLine("bobobobobob");
        }
    }
   
}
