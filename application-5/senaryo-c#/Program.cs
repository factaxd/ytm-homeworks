using System;

namespace DatabaseFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory dbFactory = new DBFactory();

            DB mysql = dbFactory.GetDB(DBFactory.MYSQL);
            DB oracle = dbFactory.GetDB(DBFactory.ORACLE);
            DB mssql = dbFactory.GetDB(DBFactory.MSSQL);

            mysql.SelectData();
            mysql.InsertData();

            oracle.SelectData();
            oracle.InsertData();

            mssql.SelectData();
            mssql.InsertData();
        }
    }
}
