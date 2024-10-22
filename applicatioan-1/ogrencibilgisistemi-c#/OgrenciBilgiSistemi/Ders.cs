using System;
using System.Collections.Generic;

public abstract class Ders
{
    public string DersAdi { get; private set; }
    public string DersKodu { get; private set; }
    public string Donem { get; private set; }
    public bool Secmeli { get; private set; }
    public Akademisyen DersSorumlusu { get; private set; }
    public int Kredi { get; private set; }
    private List<Ogrenci> ogrenciListesi;

    public Ders(string dersAdi, string dersKodu, string donem, bool secmeli, Akademisyen dersSorumlusu, int kredi)
    {
        DersAdi = dersAdi;
        DersKodu = dersKodu;
        Donem = donem;
        Secmeli = secmeli;
        DersSorumlusu = dersSorumlusu;
        Kredi = kredi;
        ogrenciListesi = new List<Ogrenci>();
    }

    public abstract string NotHesapla(params double[] notlar);

    public void DerseYazilim(Ogrenci ogrenci)
    {
        ogrenciListesi.Add(ogrenci);
    }

    public bool OgrenciKayitliMi(int numara)
    {
        foreach (Ogrenci ogrenci in ogrenciListesi)
        {
            if (ogrenci.Numara == numara)
                return true;
        }
        return false;
    }

    public void ListeyiYazdir()
    {
        Console.WriteLine(DersAdi + " Öğrenci Listesi:");
        foreach (Ogrenci ogrenci in ogrenciListesi)
        {
            Console.WriteLine(ogrenci.GetAdSoyad());
        }
    }

    protected string HarfNotu(double ortalama)
    {
        if (ortalama >= 90) return "AA";
        if (ortalama >= 80) return "BA";
        if (ortalama >= 70) return "BB";
        if (ortalama >= 60) return "CB";
        if (ortalama >= 50) return "CC";
        if (ortalama >= 40) return "DC";
        if (ortalama >= 30) return "DD";
        return "FF";
    }

    public override string ToString()
    {
        string secmeliStr = Secmeli ? "Evet" : "Hayır";
        return $"Ders: {DersAdi}, Kod: {DersKodu}, Dönem: {Donem}, Seçmeli: {secmeliStr}, Sorumlu: {DersSorumlusu}, Kredi: {Kredi}";
    }
}
