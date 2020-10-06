using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class FinalSoln
    {
        public static void validateFirstName()
        {
            string firstName = @"^[A-Z]{1}([a-zA-Z]+){2,}";
            Regex regex = new Regex(firstName);
            Console.WriteLine("Enter a valid first name :");
            String Name = Console.ReadLine();
            if (regex.IsMatch(Name))
                Console.WriteLine("The first name is valid");
            else
                Console.WriteLine("The first name is invalid , Plaese enter a name with first letter in capital and atleast 3 character");
        }
        public static void validateLastName()
        {
            string lastName = @"^[A-Z]{1}([a-zA-Z]+){2,}";
            Regex regex = new Regex(lastName);
            Console.WriteLine("Enter a valid last name :");
            String Name = Console.ReadLine();
            if (regex.IsMatch(Name))
                Console.WriteLine("The last name you entered is valid");
            else
                Console.WriteLine("The last name invalid , Plaese enter a name with first letter in capital and atleast 3 character");
        }
        public static void validateEmail()
        {
            string emailPattern = "^[a-zA-Z]+([+-_.][a-zA-Z]+)*[@][a-zA-Z]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Regex regex = new Regex(emailPattern);
            Console.WriteLine("Please enter email:");
            string email = Console.ReadLine();
            if (regex.IsMatch(email))
                Console.WriteLine("It is a valid email");
            else
                Console.WriteLine("It is not a valid email");

        }
        public static void validatePhoneNo()
        {
            string Pattern = @"^91[ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(Pattern);
            Console.WriteLine("Please enter Phone No:");
            string phoneNo = Console.ReadLine();
            if (regex.IsMatch(phoneNo))
                Console.WriteLine("It is a valid phone no.");
            else
                Console.WriteLine("It is not a valid Phone no");

        }
        public static void validatePassword()
        {
            string Pattern = @"(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z0-9@$!%*#?&]{8,}";
            Regex regex = new Regex(Pattern);
            Console.WriteLine("Please enter Password:");
            string password = Console.ReadLine();
            if (regex.IsMatch(password))
            {
                Console.WriteLine("Nice!!Strong Password");
                Console.WriteLine("*********************************************************");
            }
            else
            { 
                Console.WriteLine("It is not a valid password");
               Console.WriteLine("*********************************************************");
             }
        }
        public static void checkEmailSamples()
        {
            string[] samples = {"abc@yahoo.com","abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",
            "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc",
            "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com",
            "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a",
            "abc@gmail.com.aa.au" };
            string emailPattern = @"^[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*([@]{1}[a-zA-Z0-9]+)?([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(emailPattern);
            foreach (var sample in samples)
            {
                if (regex.IsMatch(sample))
                {
                    Console.WriteLine("Valid Email: " + sample);
                }
                else
                {
                    Console.WriteLine("Invalid email:" + sample);
                }
            }
        }
    }
}
