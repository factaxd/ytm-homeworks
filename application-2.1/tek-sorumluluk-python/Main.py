from Kullanici import Kullanici
from Adres import Adres

def main():
    kullanici = Kullanici()
    kullanici.set_isim("İsmail Yarar")
    kullanici.set_mail("ismailyarar@ktu.edu.tr")

    adres = Adres()
    adres.ulke = "Turkiye"
    adres.il = "Trabzon"
    adres.ilce = "Of"

    adres.post_kodu = 61000
    kullanici.adres_guncelle(adres)
    print(kullanici)

    adres.post_kodu = 61001
    kullanici.adres_guncelle(adres)
    print(kullanici)

if __name__ == "__main__":
    main()
