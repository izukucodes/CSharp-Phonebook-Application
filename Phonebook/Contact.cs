using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Phonebook
{
    class Contact
    {
        // Properties
        public string Name { get; set; }
        public string Number { get; set; }

        // Regex Patterns
        private string validateName = @"^[0-9A-Za-z]{3,30}$";
        private string validateNumber = @"^[0-9]{11}$";

        //Regex Functions
        private bool ValidateName(string name)
        {
            Regex rg = new Regex(validateName);
            if (rg.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidateNumber(string number)
        {
            Regex rg = new Regex(validateNumber);
            if (rg.IsMatch(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Input Contact
        public void Input()
        {
            // Loop until Name matches Regex Pattern
            while (true)
            {
                Console.Write("Enter Name: ");
                Name = Console.ReadLine();

                if (!ValidateName(Name))
                {
                    Console.WriteLine("Invalid. Please Enter Again: ");
                }
                else { break; }
            }
            // Loop until Number matches Regex Pattern
            while (true)
            {
            Console.Write("Enter Number: ");
            Number = Console.ReadLine();

                if (!ValidateNumber(Number))
                {
                    Console.WriteLine("Invalid. Please Enter Again");
                }
                else { break; }
            }
        }

        // Display Contact
        public void Display()
        {
            Console.WriteLine($"Name: {this.Name}\nNumber: {this.Number}");
        }
    }
}
