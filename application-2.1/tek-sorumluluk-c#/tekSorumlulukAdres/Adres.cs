public class Adres
{
    public string Ulke { get; set; }
    public string Il { get; set; }
    public string Ilce { get; set; }
    public int PostKodu { get; set; }

    public Adres(string ulke = "", string il = "", string ilce = "", int postKodu = 0)
    {
        Ulke = ulke;
        Il = il;
        Ilce = ilce;
        PostKodu = postKodu;
    }

    public override string ToString()
    {
        return $"{Ulke}, {Il}, {Ilce}, {PostKodu}";
    }
}