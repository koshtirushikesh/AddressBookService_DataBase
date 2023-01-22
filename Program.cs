namespace AddressBookDataBase
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddressBookDB addressBookDB = new AddressBookDB();
            addressBookDB.AddressBookDBConnection();
        }
    }

}