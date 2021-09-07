using System;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                Console.WriteLine("What kind of database would you like to use?");
                Console.WriteLine($"List\nSQL\nMogo");
                var userInput = Console.ReadLine().ToLower();
                var database = DataAccessFactory.GetDataAccessType(userInput);
                database.SaveData();
                database.LoadData();

                tryAgain = DataAccessFactory.KeepCreating();
            }
        }
    }
}
