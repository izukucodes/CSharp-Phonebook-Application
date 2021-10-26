using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        private List<Contact> Contacts { get; set; } = new List<Contact>();

        // Add Contact
        public void AddContact(Contact contact)
        {
            // Check if its Already in List
            bool isInContacts = false;
            foreach(var c in Contacts)
            {
                if(c.Number == contact.Number)
                {
                    isInContacts = true;
                    Console.WriteLine("Failed to Add Contact. Contact Number Already Exists");
                    break;
                }
            }
            // If Contact is Unique then it'll add
            if (!isInContacts) { 
            Contacts.Add(contact);
            }
        }

        // Display Single Contact
        public void DisplayContact(string number)
        {
            foreach (var c in Contacts)
            {
                if (c.Number == number)
                {
                    c.Display();
                    break;
                }
            }
        }
        
        // Display All Contacts
        public void DisplayAllContacts()
        {
            foreach(var c in Contacts)
            {
                c.Display();
                break;
            }
        }

        // Search Contact
        public void SearchContact(string name)
        {
            var cc = Contacts.Where(c => c.Name.Contains(name)).ToList<Contact>();

            foreach(var c in cc)
            {
                c.Display();
            }
        }

        // Update Contact
        public void UpdateContact(string number, Contact updatedContact)
        {
            var con = Contacts.Find(c => c.Number == number);
            con.Name = updatedContact.Name;
            con.Number = updatedContact.Number;

        }

        // Delete Contact
        public void DeleteContact(string number)
        {
            var con = Contacts.Find(c => c.Number == number);
            Contacts.Remove(con);
        }
        
    }
}
