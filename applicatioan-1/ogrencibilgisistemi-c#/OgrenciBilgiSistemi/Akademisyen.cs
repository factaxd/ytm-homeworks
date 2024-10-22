public class Akademisyen
{
    public string Ad { get; private set; }
    public string Soyad { get; private set; }

    public Akademisyen(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
    }

    public override string ToString()
    {
        return $"{Ad} {Soyad}";
    }
}
