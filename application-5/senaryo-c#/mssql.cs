using System;

namespace DatabaseFactory
{
    public class MSSQL : DB
    {
        public void SelectData()
        {
            Console.WriteLine("MSSQL veritabanından veri okundu.");
        }

        public void InsertData()
        {
            Console.WriteLine("MSSQL veritabanına veri yazıldı.");
        }
    }
}
