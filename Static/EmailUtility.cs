using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class EmailUtility
    {
        //static used before variable
        public static int count;

        //static used before Property
        public static double Length { get; set; }
        //static used before Constructor

        static EmailUtility()
        {
            count = 0;
        }
        //static used before Method
        public static void SendEmail(string name, string email,
            string subject, string body)
        {
            count++;
        }

        
    }
}
