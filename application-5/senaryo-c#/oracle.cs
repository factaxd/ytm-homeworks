using System;

namespace DatabaseFactory
{
    public class ORACLE : DB
    {
        public void SelectData()
        {
            Console.WriteLine("ORACLE veritabanından veri okundu.");
        }

        public void InsertData()
        {
            Console.WriteLine("ORACLE veritabanına veri yazıldı.");
        }
    }
}
