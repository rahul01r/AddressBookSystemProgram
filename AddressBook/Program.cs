namespace AddressBook
{
    class Program
    {
        //creating list of contact
        public static List<Contact> contactList = new List<Contact>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem.");

            Console.WriteLine("Do you want to add new contact press 1 or press 2 to cancle.");
            int num = Convert.ToInt32(Console.ReadLine());


            while (num == 1)
            {
                Contact contact1 = new Contact();
                Console.WriteLine("Enter first name: ");
                contact1.firstName = Console.ReadLine();

                Console.WriteLine("Enter last name: ");
                contact1.lastName = Console.ReadLine();

                Console.WriteLine("Enter address: ");
                contact1.address = Console.ReadLine();

                Console.WriteLine("Enter city: ");
                contact1.city = Console.ReadLine();

                Console.WriteLine("Enter state: ");
                contact1.state = Console.ReadLine();

                Console.WriteLine("Enter phone: ");
                contact1.phone = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter email: ");
                contact1.email = Console.ReadLine();

                Console.WriteLine("Enter zipcode: ");
                contact1.zipcode = Convert.ToInt32(Console.ReadLine());


                contactList.Add(contact1);

                Console.WriteLine("Do you want to add anoter contact then press 1 or press 2 for exit ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total number of contact in address book:" + contactList.Count);

            //print contacts
            Console.WriteLine("Current contacts in adress book:");

            foreach (Contact contact in contactList)
            {
                Console.WriteLine(contact.firstName);
            }

            //deleting contact
            Console.WriteLine("Do you want to delete contact press 1 to delete or press 2 to cancle.");
            num = Convert.ToInt32(Console.ReadLine());

            while (num == 1 && contactList.Count > 0)
            {
                Console.WriteLine("Enter contact First name");
                string firstName = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < contactList.Count; i++)
                {

                    if (contactList[i].firstName == firstName)
                    {
                        found = true;  //found the contact

                        contactList.RemoveAt(i);
                        break;

                    }
                }

                if (found)
                {
                    if (contactList.Count == 0) //if size 0 nothing to delete further
                        break;
                }
                else
                    Console.WriteLine("the contact with given person '{0}' is not in address book", firstName);

                Console.WriteLine("Current contacts in adress book");
                foreach (Contact contact in contactList)
                {
                    Console.WriteLine(contact.firstName);
                }
                Console.WriteLine("Do you want to delete contact press 1 to delete or press 2 to cancle.");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
    
