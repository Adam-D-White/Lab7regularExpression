using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Methods
    {
        public static string ValidateName()
        {
            string userName;

            userName = Console.ReadLine();

            bool validFullName = Regex.IsMatch(userName, @"^([A-Z{1}a-z]{1,30})\s([A-Z,a-z]{1,30})$");

            if (validFullName)
            {
                Console.WriteLine("This is a valid name.");
            }
            else
            { Console.WriteLine("This is an invalid name."); }

            return userName;








        }

        public static string ValidateEmail()
        {

            string userEmail;
            bool validEmail;

            userEmail = Console.ReadLine();

            validEmail = Regex.IsMatch(userEmail, @"^([0-9a-zA-Z._-]+){5,30}(@)([0-9a-zA-Z]+){5,10}\.([a-z]){2,3}(\s*)$");

            if (validEmail)
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }

            return userEmail;
        }

        public static string ValidatePhoneNumber()
        {
            string userPhone;
            bool validUserPhone;
            userPhone = Console.ReadLine();

            validUserPhone = Regex.IsMatch(userPhone, @"^(\d{3}-)?(\d{3}-\d{4})$");

            if (validUserPhone)
            {
                Console.WriteLine("Valid phone number");
            }
            else
            {
                Console.WriteLine("invalid phone number");
            }

            return userPhone;

        }

        public static string ValidateDate()
        {
            string userDate;
            bool validDate;
            userDate = Console.ReadLine();

            validDate = Regex.IsMatch(userDate, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[0-9])[-/.](19|20)\d\d$");

            if (validDate)
            {
                Console.WriteLine("Valid date");
            }
            else
            {
                Console.WriteLine("Invalid date");
            }

            return userDate;
        }
    }
}
