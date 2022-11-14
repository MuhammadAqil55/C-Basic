using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class cousre : student
    {
        string coursename;
        int courseid;

        public void showtime()
        {
            Console.WriteLine("hellow 8:00 am");
        }

        public void showtime(int i)
        {
            Console.WriteLine(5 * i);
        }

        public  void offtime()
        {
            Console.WriteLine("weeeklenrd 1:00 pm");
        }
    }
}
