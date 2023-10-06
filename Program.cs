using PhonebookApp.Classes;
using System.Collections;

namespace PhonebookApp
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Contact contact = new Contact();
            int option = 0;

            while (true)
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Perform a task \n Add Contact \n Delete Contact \n Search Contacts \n Print Contacts \n Exit");
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                 catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid number");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }


                if (option == 1)
                {
                    try
                    {
                        AddContact(contact);
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid name!");
                    }
                }
                else if (option == 2)
                {
                    DeleteContact(contact);
                }
                else if (option == 3)
                {
                    SearchContact(contact);
                }
                else if (option == 4)
                {
                    GetContacts(contact);
                }
                else if (option == 5)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid number!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
        }

        public static void AddContact(Contact contact)
        {
            Console.Clear();
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter Contact Name:");
                Console.ForegroundColor = ConsoleColor.White;
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter Contact Number");
                Console.ForegroundColor = ConsoleColor.White;
                int number = Int32.Parse(Console.ReadLine());
                contact.AddContact(name, number);
                Console.Clear();
            }
            catch { Console.WriteLine("Enter Valid Contact Info"); }
        }
        public static void DeleteContact(Contact contact)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Delete Contact:");
            Console.ForegroundColor = ConsoleColor.White;
            contact.RemoveContact(Console.ReadLine());
            Console.Clear();
        }
        public static void SearchContact(Contact contact)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Search Contact:");
            Console.ForegroundColor = ConsoleColor.White;
            contact.SearchContact(Console.ReadLine());
        }
        public static void GetContacts(Contact contact)
        {
            Console.Clear();
            foreach (DictionaryEntry item in contact.Hashtable)
            {
                if (!item.Equals(null))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{item.Key} - {item.Value}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Contacts Found");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}

