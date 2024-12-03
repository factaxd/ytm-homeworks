from abc import ABC, abstractmethod

class DB(ABC):
    @abstractmethod
    def select_data(self):
        pass

    @abstractmethod
    def insert_data(self):
        pass
