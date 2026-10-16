using System;
using System.Dynamic;
using System.Runtime.InteropServices.Marshalling;

namespace BankAcount
{

    public class UserData
    {
        public string Name {get; set;}
        public string Email_Address {get; set;}
        public string Password {get; set;}
    }
    class LoginPage
    {
        static void Main(string[] args)
        {
            SignUpPage();
        }

        static void SignUpPage()
        {   
            UserData customer = new UserData();

            Console.WriteLine("\nHello! New Bank Memmber.");

            Console.WriteLine("\nPlease enter your name::");
            customer.Name = Console.ReadLine();

            Console.WriteLine("\nPlease enter your email address::");
            customer.Email_Address = Console.ReadLine();

            Console.WriteLine("\nPlease enter your desired password::");
            customer.Password = Console.ReadLine();

            Access(customer);

        }
        
        static void Access(UserData customer)
        {
            //UserData customer = new UserData();
            Console.WriteLine($"Welcome! {customer.Name} @({customer.Email_Address})\n{customer.Password}");
            SignUpPage();
        }
    }
}