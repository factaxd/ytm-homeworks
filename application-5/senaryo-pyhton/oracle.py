from db import DB

class ORACLE(DB):
    def select_data(self):
        print("ORACLE veritabanından veri okundu.")

    def insert_data(self):
        print("ORACLE veritabanına veri yazıldı.")
