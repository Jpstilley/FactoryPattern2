using System;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createDatabase = true;
            while (createDatabase)
            {
                var database = DataAccessFactory.GetDataAccessType();
                database.SaveData();
                database.LoadData();

                createDatabase = DataAccessFactory.KeepCreating();
            }
        }
    }
}
