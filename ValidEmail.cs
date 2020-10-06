﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class ValidEmail
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
    }
}