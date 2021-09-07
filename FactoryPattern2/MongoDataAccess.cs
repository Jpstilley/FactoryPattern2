using System;
namespace FactoryPattern2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine($"I am reading data from a{GetType()} database");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a {GetType()} database");
        }
    }
}
