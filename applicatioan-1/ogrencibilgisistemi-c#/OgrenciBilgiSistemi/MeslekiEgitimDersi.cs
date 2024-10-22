public class MeslekiEgitimDersi : Ders
{
    public MeslekiEgitimDersi(string dersAdi, string dersKodu, string donem, bool secmeli, Akademisyen dersSorumlusu, int kredi)
        : base(dersAdi, dersKodu, donem, secmeli, dersSorumlusu, kredi) { }

    public override string NotHesapla(params double[] notlar)
    {
        if (notlar.Length != 1)
            throw new ArgumentException("Mesleki eğitim dersleri için 1 not girilmelidir.");

        return HarfNotu(notlar[0]);
    }
}
