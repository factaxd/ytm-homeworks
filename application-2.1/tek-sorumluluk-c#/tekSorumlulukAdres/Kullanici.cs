public class Kullanici
{
    public string Isim { get; set; }
    public string Mail { get; set; }
    private Adres? adres; //nullable olarak tanımladık

    public Kullanici(string isim = "", string mail = "")
    {
        Isim = isim;
        Mail = mail;
    }

    public void AdresGuncelle(Adres yeniAdres)
    {
        adres = yeniAdres;
    }

    public string GetAdres()
    {
        return adres != null ? adres.ToString() : "Adres bilgisi yok";
    }

    public void GirisYap(string mail, string sifre)
    {
        Console.WriteLine($"{Mail} ile giriş yapıldı.");
    }

    public override string ToString()
    {
        return $"{Isim} {Mail} {GetAdres()}";
    }
}
