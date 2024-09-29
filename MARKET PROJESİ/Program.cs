namespace MARKET_PROJESİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Market Projesi
             Bir markette belirli kategorilerde ürünler ve fiyatları bulunacak
                
                Gıda     => Et,Peynir,Süt 
                Giyim    => Gömlek,TShirt,Etek
                Bujiteri => Ruj,Toka,Kolye
             
             Her kategorinin kendine göre Kdv Oranı olacak
                
                Gıda     %20
                Giyim    %18
                Bujiteri %10
             
             Her alışverişte toplam ödeme tutarı 3000 üzerine çıkar ise kategoriye göre ürüne iskonto yapılacak
                
                Gıda     dan kdv oranından %4
                Giyim    dan kdv oranından %3
                Bujiteri dan kdv oranından %2

             Market müdürü ürünlerin adını,fiyatını ve kdv oranlarını ve düzenleyebilsin.(Ekle,Sil,Güncelle) 
                
             */
            Urun.UrunListele();
            Urun.URUNSATISI();
            Urun.URUNEKLE();
            Urun.URUNSIL();
            Urun.URUNGUNCELLEME();
        }
    }
}
