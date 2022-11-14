using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class student:school
    {
        int stdrollnum;
        string stdname;
        string classnum;

        //student(int stdrollnum, string stdname, string classnum)
        //{
        //    this.stdrollnum = stdrollnum;
        //    this.stdname = stdname;
        //    this.classnum = classnum;
        //}



        public void showtime()
        {
            Console.WriteLine("afternoon 8:00 am");
        }

        public override void offtime()
        {
            Console.WriteLine("Evening 1:00 pm");
        }

    }
}
