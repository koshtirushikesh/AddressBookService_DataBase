namespace AddressBookDataBase
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddressBookDB addressBookDB = new AddressBookDB();
            //addressBookDB.AddressBookDBConnection();
            Contact contact = new Contact();
            contact.First_Name = "Rushi";
            contact.Address = "3/5 jay";
            contact.Phone_Number= "1234567890";
            addressBookDB.AddressBookDBUpdate(contact);
        }
    }

}