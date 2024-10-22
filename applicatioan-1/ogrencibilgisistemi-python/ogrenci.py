class Ogrenci:
    def __init__(self, ad, soyad, numara, bolum, fakulte, giris_yili, sinif):
        self.ad = ad
        self.soyad = soyad
        self.numara = numara
        self.bolum = bolum
        self.fakulte = fakulte
        self.giris_yili = giris_yili
        self.sinif = sinif

    def get_ad_soyad(self):
        return f"{self.ad} {self.soyad}"
