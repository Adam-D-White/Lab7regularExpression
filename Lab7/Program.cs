using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("PLease enter a name.");
            Console.WriteLine(Methods.ValidateName());

            Console.WriteLine("Please enter an email address.");
            Console.WriteLine(Methods.ValidateEmail());

            Console.WriteLine("Please enter a phone number.");
            Console.WriteLine(Methods.ValidatePhoneNumber());

            Console.WriteLine("Please enter a date.");
            Console.WriteLine(Methods.ValidateDate());

        }
    }
}
