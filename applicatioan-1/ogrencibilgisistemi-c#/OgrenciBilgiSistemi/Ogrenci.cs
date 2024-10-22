public class Ogrenci
{
    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public int Numara { get; private set; }
    public string Bolum { get; private set; }
    public string Fakulte { get; private set; }
    public int GirisYili { get; private set; }
    public int Sinif { get; private set; }

    public Ogrenci(string ad, string soyad, int numara, string bolum, string fakulte, int girisYili, int sinif)
    {
        Ad = ad;
        Soyad = soyad;
        Numara = numara;
        Bolum = bolum;
        Fakulte = fakulte;
        GirisYili = girisYili;
        Sinif = sinif;
    }

    public string GetAdSoyad()
    {
        return $"{Ad} {Soyad}";
    }
}
