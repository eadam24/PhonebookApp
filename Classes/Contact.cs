using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApp.Classes
{
    internal class Contact
    {
        public Hashtable Hashtable = new Hashtable();

        public void AddContact(string name, int contactNumber)
        {
            Hashtable.Add(name, contactNumber);
        }
        
        public void RemoveContact(string name)
        {
            if(Hashtable.ContainsKey(name))
                Hashtable.Remove(name);
            else
                Console.WriteLine("No Contact Found");
        }
        public void SearchContact(string name)
        {
            if (Hashtable.ContainsKey(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Contact exists!");
                Console.WriteLine($"{name} - {Hashtable[name]}\n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
                
            else
                Console.WriteLine("No Contact Found");
        }
    }
}
