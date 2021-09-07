using System;
namespace FactoryPattern2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    Console.WriteLine($"\nThis is not a valid response.\n Please try again.\n");
                    Console.WriteLine("What kind of database would you like to use?");
                    databaseType = Console.ReadLine().ToLower();
                    return GetDataAccessType(databaseType);     
            }
        }

        public static bool KeepCreating()
        {
            Console.WriteLine($"\nWould you like to creata another database?");
            var userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                case "y":
                    return true;
                case "no":
                case "n":
                    return false;
                default:
                    Console.WriteLine($"\nThis is not a valid response.\n Please try again.");
                    return KeepCreating(); 
            }
                 
        }
    }
}
