using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Press 1 to Add Contact ");
            Console.WriteLine("Press 2 to Display Contact Details ");
            Console.WriteLine("Press 3 to All Contacts ");
            Console.WriteLine("Press 4 to Search Contacts ");
            Console.WriteLine("Press 5 to Update Contact ");
            Console.WriteLine("Press 6 to Remove Contact ");
            Console.WriteLine("Press 7 to Clear Screen ");
            Console.WriteLine("Press 8 to Exit");
        }
        static void Main(string[] args)
        {
            Phonebook PhoneBook = new Phonebook();
            int choice;
            while (true)
            {
                // Displaying Menu
                Menu();
                Console.Write("Enter Choice: ");

                // Validating Choice Value
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Invalid Choice. Please Enter Again: ");
                }

                // Add Contact
                if (choice == 1)
                {
                    Contact c = new Contact();
                    c.Input();
                    PhoneBook.AddContact(c);
                }
                
                // Display Contact
                else if (choice == 2)
                {
                    Console.Write("Enter Number: ");
                    string number = Console.ReadLine();
                    PhoneBook.DisplayContact(number);
                }
                
                // Display All
                else if (choice == 3)
                {
                    PhoneBook.DisplayAllContacts();
                }
                
                // Search Contact
                else if (choice == 4)
                {
                    Console.Write("Enter Search Phrase: ");
                    string name = Console.ReadLine();
                    PhoneBook.SearchContact(name);
                }
                
                // Update Contact
                else if(choice == 5)
                {
                    Console.Write("Enter Contact Number that you wanna Update: ");
                    string number = Console.ReadLine();

                    Contact updatedContact = new Contact();
                    Console.WriteLine("Enter New Contact Details");
                    updatedContact.Input();

                    PhoneBook.UpdateContact(number, updatedContact);
                }
                
                // Delete Contact
                else if(choice == 6){
                    Console.Write("Enter Contact Number that you wanna Delete:");
                    string number = Console.ReadLine();
                }
                
                // Clear Screen
                else if (choice == 7)
                {
                    Console.Clear();
                }
                
                // Exit
                else if (choice == 8)
                {
                    break;
                }
            }
        }
    }
}
