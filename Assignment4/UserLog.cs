using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class UserLog

    {
        static int UserCount=0;
        //public string Name { get; set; }
        //public double Salary { get; set; }

        public UserLog(string name) {
            UserCount++;
            Console.WriteLine($"{name} login successfully.");
        }

        public static void GetUserCount() {
            Console.WriteLine($"UserCount: {UserCount}");
        }
    }

}
