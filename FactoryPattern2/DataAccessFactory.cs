using System;
namespace FactoryPattern2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType()
        {
            Console.WriteLine("What kind of database would you like to use?");
            Console.WriteLine($"List\nSQL\nMongo");
            var databaseType = Console.ReadLine().ToLower();
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
                    return GetDataAccessType();     
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
