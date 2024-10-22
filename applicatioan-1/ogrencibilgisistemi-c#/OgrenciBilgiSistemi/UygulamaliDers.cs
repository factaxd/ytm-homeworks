public class UygulamaliDers : Ders
{
    public UygulamaliDers(string dersAdi, string dersKodu, string donem, bool secmeli, Akademisyen dersSorumlusu, int kredi)
        : base(dersAdi, dersKodu, donem, secmeli, dersSorumlusu, kredi) { }

    public override string NotHesapla(params double[] notlar)
    {
        if (notlar.Length != 2)
            throw new ArgumentException("Uygulamalı dersler için 2 not girilmelidir (Vize, Final).");

        double ortalama = (notlar[0] * 0.4) + (notlar[1] * 0.6);
        return HarfNotu(ortalama);
    }
}
