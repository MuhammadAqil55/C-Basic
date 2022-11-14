using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class school
    {
        string schoolname;
        string address;
        string school_id;

        //school(string schoolname, string address, string school_id)
        //{
        //    this.schoolname = schoolname;
        //    this.address = address;
        //    this.school_id = school_id;
        //}

        public void showtime()
        {
            Console.WriteLine("morning 8:00 am");
        }

        public virtual void offtime()
        {
            Console.WriteLine("time off 1:00 pm");
        }


    }

}
