from mysql import MYSQL
from oracle import ORACLE
from mssql import MSSQL

class DBFactory:
    MYSQL = 1
    ORACLE = 2
    MSSQL = 3

    @staticmethod
    def get_db(db_type):
        if db_type == DBFactory.MYSQL:
            return MYSQL()
        elif db_type == DBFactory.ORACLE:
            return ORACLE()
        elif db_type == DBFactory.MSSQL:
            return MSSQL()
        else:
            return None
