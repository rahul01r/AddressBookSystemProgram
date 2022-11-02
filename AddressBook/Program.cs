namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "Rahul Ranjan",
                LastName = "Dubey",
                Address = "Ranchi",
                City = "Ranchi",
                State = "Jharkhand",
                Zip = 834001,
                PhoneNumber = 635313213,
                Email = "rrdubeyni@gmail.com",
            };
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
}
    
