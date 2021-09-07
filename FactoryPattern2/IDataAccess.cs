using System;
namespace FactoryPattern2
{
    public interface IDataAccess
    {

        public void LoadData();
        public void SaveData();

    }
}
