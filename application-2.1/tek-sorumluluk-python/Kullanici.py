from Adres import Adres

class Kullanici:
    def __init__(self, isim="", mail=""):
        self.isim = isim
        self.mail = mail
        self.adres = None  # Başlangıçta adres boş 

    def set_isim(self, isim):
        self.isim = isim

    def get_isim(self):
        return self.isim

    def set_mail(self, mail):
        self.mail = mail

    def get_mail(self):
        return self.mail

    def adres_guncelle(self, adres):
        if isinstance(adres, Adres):
            self.adres = adres
        else:
            raise TypeError("Adres nesnesi verilmelidir.")

    def get_adres(self):
        return str(self.adres) if self.adres else "Adres bilgisi yok"

    def giris_yap(self, mail, sifre):
        print(f"{self.mail} ile giriş yapıldı.")

    def __str__(self):
        return f"{self.get_isim()} {self.get_mail()} {self.get_adres()}"
