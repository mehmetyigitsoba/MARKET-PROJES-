using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MARKET_PROJESİ
{
    internal class Urun
    {
        internal static  string [] gida = { "ET", "PEYNİR", "SÜT" };
        internal static  string [] giyim = { "GÖMLEK", "TSHİRT", "ETEK" };
        internal static  string [] bujiteri = { "RUJ", "KOLYE", "TOKA" };
        internal static double[] gidaFiyat = { 600, 300, 150 };
        internal static double[] giyimFiyat = { 1000, 900, 800 };
        internal static double[] bujiteriFiyat = { 300, 450, 100 };
        internal static string yeniUrun = "";
        internal static double alisverisTutari = 0;

        internal static double yeniUrunFiyat = 0;
        internal static int  guncellenecekUrun = 0;


        internal static void UrunListele()
        {
            Console.WriteLine("ÜRÜN LİSTESİ");
            int uzunluk = 0;
            if (gida.Length >= giyim.Length && gida.Length >= bujiteri.Length)
            {
                uzunluk = gida.Length;
            }
            else if (giyim.Length >= gida.Length && giyim.Length >= bujiteri.Length)
            {
                uzunluk = giyim.Length;
            }
            else
            {
                uzunluk = bujiteri.Length;
            }
            for (int i = 0; i < uzunluk; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("GIDA");
                }
                else if (i == 1)
                {
                    Console.WriteLine("GİYİM");
                }
                else
                {
                    Console.WriteLine("BUJİTERİ");
                }
                Console.WriteLine($"{gida[i]},{giyim[i]},{bujiteri[i]}");
                Console.WriteLine($"{gidaFiyat[i]}TL,{giyimFiyat[i]}TL,{bujiteriFiyat[i]}TL");
            }
        }
        internal static void URUNSATISI()
        {
            Console.WriteLine("ÜRÜN SATIŞI");
            while (true)
            {
                
                Console.WriteLine("gıda için-1\ngiyim için-2\nbujiteri için\nçıkmak için -0\nne istersiniz");
                int secenek = Convert.ToInt32(Console.ReadLine());
                if (secenek == 1)
                {
                    for (int i = 0; i < gida.Length; i++)
                    {
                        Console.WriteLine($"{gida[i]}");
                        Console.WriteLine($"{gidaFiyat[i]}TL");
                    }
                    Console.WriteLine("ne istersiniz");
                    alisverisTutari += gidaFiyat[Array.IndexOf(gida, Console.ReadLine().ToUpper())] * 1.2;
                    Console.WriteLine("alışveriş tutarı:" + alisverisTutari);

                }
                else if (secenek == 2)
                {
                    for (int i = 0; i < giyim.Length; i++)
                    {
                        Console.WriteLine($"{giyim[i]}");
                        Console.WriteLine($"{giyimFiyat[i]}TL");
                    }
                    Console.WriteLine("ne istersiniz");
                    alisverisTutari += giyimFiyat[Array.IndexOf(giyim, Console.ReadLine().ToUpper())] * 1.18;
                    Console.WriteLine("alışveriş tutarı:" + alisverisTutari);

                }
                else if (secenek == 3)
                {
                    for (int i = 0; i < bujiteri.Length; i++)
                    {
                        Console.WriteLine($"{bujiteri[i]}");
                        Console.WriteLine($"{bujiteriFiyat[i]}TL");
                    }
                    Console.WriteLine("ne istersiniz");
                    alisverisTutari += bujiteriFiyat[Array.IndexOf(bujiteri, Console.ReadLine().ToUpper())] * 1.1;
                    Console.WriteLine("alışveriş tutarı:" + alisverisTutari);

                }
                else if (secenek == 0)
                {
                    Console.WriteLine("alışveriş tutarı:" + alisverisTutari);
                    Console.WriteLine("yine belkeriz");
                    break;

                }
                else
                {
                    Console.WriteLine("hatalı işlem");
                }
            }
            
        }
        internal static void URUNEKLE()
        {
            Console.WriteLine("ÜRÜN EKLE");
            while (true)
            {
                Console.WriteLine("gıda için-1\ngiyim için-2\nbujiteri için\nçıkmak için -0\nhangi reyona ürün eklemek istersiniz");
                int secenek = Convert.ToInt32(Console.ReadLine());
                if (secenek == 1)
                {
                    Array.Resize(ref gida, gida.Length + 1);
                    Array.Resize(ref gidaFiyat, gidaFiyat.Length + 1);
                    Console.WriteLine("eklemek istediğiniz ürünü girin");
                    yeniUrun = Console.ReadLine().ToUpper();
                    gida[gida.Length - 1] = yeniUrun;
                    Console.WriteLine("eklemek istediğiniz ürününün fiyatını  girin");
                    yeniUrunFiyat = Convert.ToInt32(Console.ReadLine());
                    gidaFiyat[gidaFiyat.Length - 1] = yeniUrunFiyat;
                    for (int i = 0; i < gida.Length; i++)
                    {
                        Console.WriteLine($"{gida[i]}");
                        Console.WriteLine($"{gidaFiyat[i]}TL");
                    }
                    
                }
                else if (secenek == 2)
                {
                    Array.Resize(ref giyim, giyim.Length + 1);
                    Array.Resize(ref giyimFiyat, giyimFiyat.Length + 1);
                    Console.WriteLine("eklemek istediğiniz ürünü girin");
                    yeniUrun = Console.ReadLine().ToUpper();
                    giyim[giyim.Length - 1] = yeniUrun;
                    Console.WriteLine("eklemek istediğiniz ürününün fiyatını  girin");
                    yeniUrunFiyat = Convert.ToInt32(Console.ReadLine());
                    giyimFiyat[giyimFiyat.Length - 1] = yeniUrunFiyat;
                    for (int i = 0; i < gida.Length; i++)
                    {
                        Console.WriteLine($"{giyim[i]}");
                        Console.WriteLine($"{giyimFiyat[i]}TL");
                    }
                }
                else if (secenek == 3)
                {
                    Array.Resize(ref bujiteri, bujiteri.Length + 1);
                    Array.Resize(ref bujiteriFiyat, bujiteriFiyat.Length + 1);
                    Console.WriteLine("eklemek istediğiniz ürünü girin");
                    yeniUrun = Console.ReadLine().ToUpper();
                    bujiteri[bujiteri.Length - 1] = yeniUrun;
                    Console.WriteLine("eklemek istediğiniz ürününün fiyatını  girin");
                    yeniUrunFiyat = Convert.ToInt32(Console.ReadLine());
                    bujiteriFiyat[bujiteriFiyat.Length - 1] = yeniUrunFiyat;
                    for (int i = 0; i < bujiteri.Length; i++)
                    {
                        Console.WriteLine($"{bujiteri[i]}");
                        Console.WriteLine($"{bujiteriFiyat[i]}TL");
                    }
                }
                else if (secenek == 0)
                {

                   
                    Console.WriteLine("çıkış yaptınız");
                    break;
                }
                else
                {
                    Console.WriteLine("hatalı işlem");
                }



            }
        }
        internal static void URUNSIL()
        {
            Console.WriteLine("ÜRÜN SİL");
            while (true)
            {
                Console.WriteLine("gıda için-1\ngiyim için-2\nbujiteri için\nçıkmak için -0\nhangi reyondan ürün silmek istersiniz");
                int secenek = Convert.ToInt32(Console.ReadLine());
                
                if (secenek == 1)
                {
                    for (int i = 0; i < gida.Length; i++)
                    {
                        Console.WriteLine($"{gida[i]}");
                        Console.WriteLine($"{gidaFiyat[i]}TL");
                    }
                    Console.WriteLine("silmek istediğiniz ürünün indexNo:");
                    int silinecekUrun = Convert.ToInt32(Console.ReadLine());
                    Array.Clear(gida, silinecekUrun, 1);
                    Array.Clear(gidaFiyat, silinecekUrun, 1);
                    for (int i = 0; i < gida.Length; i++)
                    {
                        Console.WriteLine($"{gida[i]}");
                        Console.WriteLine($"{gidaFiyat[i]}TL");
                    }



                }
                else if (secenek == 2)
                {
                    for (int i = 0; i < giyim.Length; i++)
                    {
                        Console.WriteLine($"{giyim[i]}");
                        Console.WriteLine($"{giyimFiyat[i]}TL");
                    }
                    Console.WriteLine("hangi ürünü silmek istersiniz");
                    int silinecekUrun = Convert.ToInt32(Console.ReadLine());
                    Array.Clear(giyim, silinecekUrun, 1);
                    Array.Clear(giyimFiyat, silinecekUrun, 1);
                    for (int i = 0; i < gida.Length; i++)
                    {
                        Console.WriteLine($"{giyim[i]}");
                        Console.WriteLine($"{giyimFiyat[i]}TL");
                    }



                }
                else if (secenek == 3)
                {
                    for (int i = 0; i < bujiteri.Length; i++)
                    {
                        Console.WriteLine($"{bujiteri[i]}");
                        Console.WriteLine($"{bujiteriFiyat[i]}TL");
                    }
                    Console.WriteLine("hangi ürünü silmek istersiniz");
                    int silinecekUrun = Convert.ToInt32(Console.ReadLine());
                    Array.Clear(bujiteri, silinecekUrun, 1);
                    Array.Clear(bujiteriFiyat, silinecekUrun, 1);
                    for (int i = 0; i < bujiteri.Length; i++)
                    {
                        Console.WriteLine($"{bujiteri[i]}");
                        Console.WriteLine($"{bujiteriFiyat[i]}TL");
                    }



                }
                else if (secenek == 0)
                {


                    Console.WriteLine("çıkış yaptınız");
                    break;
                }
                else
                {
                    Console.WriteLine("hatalı işlem");
                }

            }
        }
        internal static void URUNGUNCELLEME()
        {
            Console.WriteLine("ÜRÜN GÜNCELLEME");
            while (true)
            {
                Console.WriteLine("gıda için-1\ngiyim için-2\nbujiteri için\nçıkmak için -0\nhangi reyondan ürün güncellemek istersiniz");
                int secenek = Convert.ToInt32(Console.ReadLine());
                
                if (secenek == 1)
                {
                    Console.WriteLine("güncellemek isteğiniz ürününün index no:");
                    guncellenecekUrun = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ürününüzü güncelleyin");

                    gida[guncellenecekUrun] = Console.ReadLine().ToUpper();
                    Console.WriteLine("güncellenmiş ürünün fiyatını girin:");
                   gidaFiyat[guncellenecekUrun] = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < gida.Length; i++)
                    {
                        Console.WriteLine($"{gida[i]}");
                        Console.WriteLine($"{gidaFiyat[i]}TL");
                    }
                }
                else if (secenek == 2)
                {
                    Console.WriteLine("güncellemek isteğiniz ürününün index no:");
                    guncellenecekUrun = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ürününüzü güncelleyin");

                    giyim[guncellenecekUrun] = Console.ReadLine().ToUpper();
                    Console.WriteLine("güncellenmiş ürünün fiyatını girin:");
                    giyimFiyat[guncellenecekUrun] = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < giyim.Length; i++)
                    {
                        Console.WriteLine($"{giyim[i]}");
                        Console.WriteLine($"{giyimFiyat[i]}TL");
                    }
                }
                else if (secenek == 3)
                {
                    Console.WriteLine("güncellemek isteğiniz ürününün index no:");
                    guncellenecekUrun = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ürününüzü güncelleyin");

                   bujiteri[guncellenecekUrun] = Console.ReadLine().ToUpper();
                    Console.WriteLine("güncellenmiş ürünün fiyatını girin:");
                    bujiteriFiyat[guncellenecekUrun] = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < bujiteri.Length; i++)
                    {
                        Console.WriteLine($"{bujiteri[i]}");
                        Console.WriteLine($"{bujiteriFiyat[i]}TL");
                    }
                }
                else if (secenek == 0)
                {
                    Console.WriteLine("çıkış yaptınız");
                    break;
                }
                else
                {
                    Console.WriteLine("hatalı işlem");
                }
            }
        }
    }
}
