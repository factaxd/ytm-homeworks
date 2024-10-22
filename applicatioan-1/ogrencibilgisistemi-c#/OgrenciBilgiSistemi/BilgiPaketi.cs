using System;
using System.Collections.Generic;

public class BilgiPaketi
{
    private List<Ders> tumDersler;

    public BilgiPaketi()
    {
        tumDersler = new List<Ders>();
    }

    public void DersEkle(Ders ders)
    {
        tumDersler.Add(ders);
    }

    public void TranskriptSorgula(Ogrenci ogrenci)
    {
        Console.WriteLine(ogrenci.GetAdSoyad() + " Ders Listesi:");
        foreach (Ders ders in tumDersler)
        {
            if (ders.OgrenciKayitliMi(ogrenci.Numara))
            {
                if (ders is TemelDers)
                {
                    Console.WriteLine($"{ders.DersAdi} dersi, Kredisi: {ders.Kredi}, Harf Notu: {ders.NotHesapla(80, 70, 90)}");
                }
                else if (ders is UygulamaliDers)
                {
                    Console.WriteLine($"{ders.DersAdi} dersi, Kredisi: {ders.Kredi}, Harf Notu: {ders.NotHesapla(85, 75)}");
                }
                else if (ders is MeslekiEgitimDersi)
                {
                    Console.WriteLine($"{ders.DersAdi} dersi, Kredisi: {ders.Kredi}, Harf Notu: {ders.NotHesapla(95)}");
                }
            }
        }
    }
}
