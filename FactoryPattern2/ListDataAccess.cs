using System;
namespace FactoryPattern2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
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
