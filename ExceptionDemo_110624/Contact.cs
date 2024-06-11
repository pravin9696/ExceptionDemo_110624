using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo_110624
{
    class Phone_book
    {
        public Contact[] contacts = new Contact[10];
        //public Contact[] contacts { get; set; }
        public Phone_book()
        {
          
            for (int i = 0; i < contacts.Length; i++)
            {
                contacts[i] = new Contact();
                contacts[i].name = "empty";
            }
        }
        public Contact this[int index]
        {
            get { return contacts[index]; }
            set { contacts[index] = value; }
        }
    }
    internal class Contact
    {
        public int number { get; set; }
        public string name { get; set; }

        public void show()
        {
            Console.WriteLine("Number :"+number+" Name :"+name);
        }
    }
}
