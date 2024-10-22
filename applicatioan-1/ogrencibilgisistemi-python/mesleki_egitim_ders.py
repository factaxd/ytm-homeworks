from ders import Ders

class MeslekiEgitimDersi(Ders):
    def __init__(self, ders_adi, ders_kodu, donem, secmeli, ders_sorumlusu, kredi):
        super().__init__(ders_adi, ders_kodu, donem, secmeli, ders_sorumlusu, kredi)
        self.ogrenci_notlari = {}

    def not_gir(self, ogrenci, proje_notu):
        if ogrenci not in self.ogrenci_listesi:
            raise ValueError(f"{ogrenci.get_ad_soyad()} bu derse kayıtlı değil.")

        self.ogrenci_notlari[ogrenci.numara] = proje_notu

    def not_hesapla(self, ogrenci):
        if ogrenci.numara not in self.ogrenci_notlari:
            raise ValueError(f"{ogrenci.get_ad_soyad()} için not girişi yapılmamış.")

        proje_notu = self.ogrenci_notlari[ogrenci.numara]
        return self.harf_notu(proje_notu)

    def ogrenci_transkripti(self, ogrenci):
        if ogrenci.numara in self.ogrenci_notlari:
            proje_notu = self.ogrenci_notlari[ogrenci.numara]
            harf_notu = self.not_hesapla(ogrenci)
            print(f"{ogrenci.get_ad_soyad()} için notlar - Proje Notu: {proje_notu}, Harf Notu: {harf_notu}")
        else:
            print(f"{ogrenci.get_ad_soyad()} için not girilmemiş.")
