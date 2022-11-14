using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
      internal class Pet : Animal
    {
        public override void sound()
        {
            throw new NotImplementedException();
        }

        public void Mynewfunct()
        {
            base.voice();
        }

        public void fun()
        {
            Console.WriteLine("hahahaha");
        }

    }
}
