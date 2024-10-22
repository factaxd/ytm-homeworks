class Akademisyen:
    def __init__(self, ad, soyad):
        self.ad = ad
        self.soyad = soyad

    def __str__(self):
        return f"{self.ad} {self.soyad}"
