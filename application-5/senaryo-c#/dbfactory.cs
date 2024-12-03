using System;

namespace DatabaseFactory
{
    public class DBFactory
    {
        public const int MYSQL = 1;
        public const int ORACLE = 2;
        public const int MSSQL = 3;

        public DB GetDB(int type)
        {
            switch (type)
            {
                case MYSQL:
                    return new MYSQL();
                case ORACLE:
                    return new ORACLE();
                case MSSQL:
                    return new MSSQL();
                default:
                    return null;
            }
        }
    }
}
