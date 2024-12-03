using System;

namespace DatabaseFactory
{
    public class MYSQL : DB
    {
        public void SelectData()
        {
            Console.WriteLine("MYSQL veritabanından veri okundu.");
        }

        public void InsertData()
        {
            Console.WriteLine("MYSQL veritabanına veri yazıldı.");
        }
    }
}
