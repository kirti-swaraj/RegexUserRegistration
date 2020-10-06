using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Rule1.validateFirstName();
            Rule1.validateLastName();
            Rule1.validateEmail();
            Rule1.validatePhoneNo();
            Rule1.validatePassword();

        }
    }
}

