from db_factory import DBFactory

if __name__ == "__main__":
    db_factory = DBFactory()

    mysql = db_factory.get_db(DBFactory.MYSQL)
    oracle = db_factory.get_db(DBFactory.ORACLE)
    mssql = db_factory.get_db(DBFactory.MSSQL)

    mysql.select_data()
    mysql.insert_data()

    oracle.select_data()
    oracle.insert_data()

    mssql.select_data()
    mssql.insert_data()
