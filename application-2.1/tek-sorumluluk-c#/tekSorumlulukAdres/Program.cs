using System;

class Program
{
    static void Main(string[] args)
    {
        Kullanici kullanici = new Kullanici();
        kullanici.Isim = "İsmail Yarar";
        kullanici.Mail = "ismailyarar@ktu.edu.tr";

        Adres adres = new Adres
        {
            Ulke = "Turkiye",
            Il = "Trabzon",
            Ilce = "Of",
            PostKodu = 61000
        };

        kullanici.AdresGuncelle(adres);
        Console.WriteLine(kullanici);

        adres.PostKodu = 61001;
        kullanici.AdresGuncelle(adres);
        Console.WriteLine(kullanici);
    }
}
