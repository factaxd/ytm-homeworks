from ogrenci import Ogrenci
from akademisyen import Akademisyen
from temel_ders import TemelDers
from uygulamali_ders import UygulamaliDers
from mesleki_egitim_ders import MeslekiEgitimDersi
from bilgi_paketi import BilgiPaketi

def main():
    ogrenci1 = Ogrenci("Selim", "Veli", 1, "Yazılım Mühendisliği", "Mühendislik Fakültesi", 2024, 1)
    ogrenci2 = Ogrenci("Ayşe", "Kaya", 2, "Yazılım Mühendisliği", "Mühendislik Fakültesi", 2024, 1)

    akademisyen1 = Akademisyen("Dr. Mehmet", "Yılmaz")
    akademisyen2 = Akademisyen("Prof. Ayşe", "Çelebi")
    akademisyen3 = Akademisyen("Doç. Dr. Zeynep", "Erdoğan")

    bilgi_paketi = BilgiPaketi()

    temel_ders = TemelDers("Yazılım Mimarileri", "101", "Güz", False, akademisyen1, 4)
    uygulamali_ders = UygulamaliDers("Yazılım Laboratuvarı", "301", "Güz", False, akademisyen2, 3)
    mesleki_egitim_dersi = MeslekiEgitimDersi("Mesleki Eğitim", "401", "Bahar", True, akademisyen3, 2)

    bilgi_paketi.ders_ekle(temel_ders)
    bilgi_paketi.ders_ekle(uygulamali_ders)
    bilgi_paketi.ders_ekle(mesleki_egitim_dersi)

    temel_ders.derse_yazilim(ogrenci1)
    temel_ders.derse_yazilim(ogrenci2)

    uygulamali_ders.derse_yazilim(ogrenci1)
    uygulamali_ders.derse_yazilim(ogrenci2)

    mesleki_egitim_dersi.derse_yazilim(ogrenci1)
    mesleki_egitim_dersi.derse_yazilim(ogrenci2)

    temel_ders.not_gir(ogrenci1, 85, 90, 80) 
    temel_ders.not_gir(ogrenci2, 75, 70, 65) 

    uygulamali_ders.not_gir(ogrenci1, 88, 92)
    uygulamali_ders.not_gir(ogrenci2, 78, 85) 

    mesleki_egitim_dersi.not_gir(ogrenci1, 95)
    mesleki_egitim_dersi.not_gir(ogrenci2, 85)  

    temel_ders.listeyi_yazdir()
    uygulamali_ders.listeyi_yazdir()
    mesleki_egitim_dersi.listeyi_yazdir()

    bilgi_paketi.transkript_sorgula(ogrenci1)
    bilgi_paketi.transkript_sorgula(ogrenci2)

if __name__ == "__main__":
    main()
