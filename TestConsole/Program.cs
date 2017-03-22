using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLLibrary;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SQL mySQL = new SQL();

            //List<Contact> contacts = GetAllData();

            //AddContact();

            //UpdateContact();

            GetAllData();

            //SearchContactIDByName();

            GetContactById();

            // TODO Lägga till response ifall person ej finns i listan, Kolla även så att RemoveContact fungerar
        }

        private static void GetContactById()
        {
            //Contact contact = SQL.GetContactById("7");
            //Console.WriteLine(contact);
            Console.WriteLine("Ange ID nummer");
            string inputID = Console.ReadLine(); //ID är string??

            Console.WriteLine(SQL.GetContactById(inputID));
        }

        //private static List<Contact> SearchContactIDByName()
        //{
        //    List<Contact> findContacts;

        //    Console.WriteLine("Ange förnamn att söka");
        //    string inputFirstName = Console.ReadLine();

        //    Console.WriteLine("Ange efternamn att söka");
        //    string inputLastName = Console.ReadLine();

        //    findContacts = SQL.SearchContactIDByName(inputFirstName, inputLastName);

        //    foreach (var contact in findContacts)
        //    {
        //        Console.WriteLine(contact.ToString());
        //    }

        //    return findContacts;
        //}

        //private static void UpdateContact()
        //{
        //    List<Contact> updatedContacts;

        //    Console.WriteLine("Ange ID att byta ut");
        //    int findIDTOChange = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Ange förnamn att byta till: ");
        //    string newfirstName = Console.ReadLine();

        //    Console.WriteLine("Ange efternamn att byta till: ");
        //    string newlastName = Console.ReadLine();

        //    updatedContacts = SQL.UpdateContact(findIDTOChange, newfirstName, newlastName);
        //}

        //private static void AddContact()
        //{
        //    Console.WriteLine("Ange förnamn att lägga till: ");
        //    string firstName = Console.ReadLine();

        //    Console.WriteLine("Ange efternamn att lägga till: ");
        //    string lastName = Console.ReadLine();

        //    Console.WriteLine(SQL.AddContact(firstName, lastName));
        //}

        private static List<Contact> GetAllData()
        {
            List<Contact> contacts = SQL.SearchContactIDByName();

            foreach (var contact in contacts)
            {
                //Console.WriteLine(contact.ToString());
                contacts.Add(contact);
            }

            return contacts;
        }
    }
}
