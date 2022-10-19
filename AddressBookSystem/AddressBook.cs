using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public void createContact()
        {
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string LastNme = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter zip code");
            int Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone number");
            long PhoneNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email-id");
            string Email = Console.ReadLine();

        }
    }
}
