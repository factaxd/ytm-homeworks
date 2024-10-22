using System;

public class Program
{
    public static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci("Ali", "Veli", 1, "Yazılım Mühendisliği", "Mühendislik Fakültesi", 2024, 1);
        Ogrenci ogrenci2 = new Ogrenci("Ayşe", "Kaya", 2, "Yazılım Mühendisliği", "Mühendislik Fakültesi", 2024, 1);
        Ogrenci ogrenci3 = new Ogrenci("Fatma", "Demir", 3, "Yazılım Mühendisliği", "Mühendislik Fakültesi", 2024, 1);

        Akademisyen akademisyen1 = new Akademisyen("Dr. Mehmet", "Yılmaz");
        Akademisyen akademisyen2 = new Akademisyen("Prof. Ayşe", "Çelik");

        BilgiPaketi bilgiPaketi = new BilgiPaketi();

        TemelDers ders1 = new TemelDers("Yazılım Tasarım Mimarisi", "101", "Güz", false, akademisyen1, 4);
        UygulamaliDers lab1 = new UygulamaliDers("Yazılım Laboratuvarı", "301", "Güz", false, akademisyen2, 3);

        bilgiPaketi.DersEkle(ders1);
        bilgiPaketi.DersEkle(lab1);

        ders1.DerseYazilim(ogrenci1);
        ders1.DerseYazilim(ogrenci2);
        ders1.DerseYazilim(ogrenci3);

        lab1.DerseYazilim(ogrenci1);
        lab1.DerseYazilim(ogrenci3);


        ders1.ListeyiYazdir();
        lab1.ListeyiYazdir();

        bilgiPaketi.TranskriptSorgula(ogrenci1);
        bilgiPaketi.TranskriptSorgula(ogrenci2);
    }
}
