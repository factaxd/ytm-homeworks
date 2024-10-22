from ders import Ders

class TemelDers(Ders):
    def __init__(self, ders_adi, ders_kodu, donem, secmeli, ders_sorumlusu, kredi):
        super().__init__(ders_adi, ders_kodu, donem, secmeli, ders_sorumlusu, kredi)
        self.ogrenci_notlari = {}

    def not_gir(self, ogrenci, vize, final, proje):
        if ogrenci not in self.ogrenci_listesi:
            raise ValueError(f"{ogrenci.get_ad_soyad()} bu derse kayıtlı değil.")
        
        self.ogrenci_notlari[ogrenci.numara] = (vize, final, proje)

    def not_hesapla(self, ogrenci):
        if ogrenci.numara not in self.ogrenci_notlari:
            raise ValueError(f"{ogrenci.get_ad_soyad()} için not girişi yapılmamış.")

        vize, final, proje = self.ogrenci_notlari[ogrenci.numara]
        ortalama = (vize * 0.3) + (final * 0.5) + (proje * 0.2)
        return self.harf_notu(ortalama)

    def ogrenci_transkripti(self, ogrenci):
        if ogrenci.numara in self.ogrenci_notlari:
            vize, final, proje = self.ogrenci_notlari[ogrenci.numara]
            harf_notu = self.not_hesapla(ogrenci)
            print(f"{ogrenci.get_ad_soyad()} için notlar - Vize: {vize}, Final: {final}, Proje: {proje}, Harf Notu: {harf_notu}")
        else:
            print(f"{ogrenci.get_ad_soyad()} için not girilmemiş.")