class BilgiPaketi:
    def __init__(self):
        self.tum_dersler = []

    def ders_ekle(self, ders):
        self.tum_dersler.append(ders)

    def transkript_sorgula(self, ogrenci):
        print(f"{ogrenci.get_ad_soyad()} Ders Listesi:")
        for ders in self.tum_dersler:
            if ders.ogrenci_kayitli_mi(ogrenci.numara):
                try:
                    harf_notu = ders.not_hesapla(ogrenci)
                    print(f"{ders.ders_adi} dersi, Kredisi: {ders.kredi}, Harf Notu: {harf_notu}")
                except ValueError as e:
                    print(f"{ders.ders_adi} dersi için not girilmemiş.")
