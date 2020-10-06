using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class AddName
    {
        public static void validateFirstName()
        {
            string firstName = @"^[A-Z]{1}([a-zA-Z]+){2,}";
            Regex regex = new Regex(firstName);
            Console.WriteLine("Enter a valid first name :");
            String Name = Console.ReadLine();
            if(regex.IsMatch(Name))
                Console.WriteLine("The name you entered is valid");
            else
                Console.WriteLine("The name you entered is not valid , Plaese enter a name with first leeter in capital and atleast 3 character");
        }
    }
}
