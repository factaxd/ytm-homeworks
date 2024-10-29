class Adres:
    def __init__(self, ulke="", il="", ilce="", post_kodu=0):
        self._ulke = ulke
        self._il = il
        self._ilce = ilce
        self._post_kodu = post_kodu

    @property
    def ulke(self):
        return self._ulke

    @ulke.setter
    def ulke(self, ulke):
        self._ulke = ulke

    @property
    def il(self):
        return self._il

    @il.setter
    def il(self, il):
        self._il = il

    @property
    def ilce(self):
        return self._ilce

    @ilce.setter
    def ilce(self, ilce):
        self._ilce = ilce

    @property
    def post_kodu(self):
        return self._post_kodu

    @post_kodu.setter
    def post_kodu(self, post_kodu):
        self._post_kodu = post_kodu

    def __str__(self):
        return f"{self.ulke}, {self.il}, {self.ilce}, {self.post_kodu}"
