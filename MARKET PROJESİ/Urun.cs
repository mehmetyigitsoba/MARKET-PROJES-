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
        internal static string[] gida = { "ET", "PEYNİR", "SÜT" };
        internal static string[] giyim = { "GÖMLEK", "TSHİRT", "ETEK" };
        internal static string[] bujiteri = { "RUJ", "KOLYE", "TOKA" };
        internal static double[] gidaFiyat = { 600, 300, 150 };
        internal static double[] giyimFiyat = { 1000, 900, 800 };
        internal static double[] bujiteriFiyat = { 300, 450, 100 };
        internal static string yeniUrun = "";
        internal static double alisverisTutari = 0;
        internal static string [] [] ürünler = { gida, giyim, bujiteri };
        internal static double [][] ürünFiyatlar = { gidaFiyat, giyimFiyat, bujiteriFiyat };
        internal static int uzunluk = 0;
        internal static int n = 0;
        internal static int  m = 0;



        internal static double yeniUrunFiyat = 0;
        internal static int guncellenecekUrun = 0;


        internal static string[] reyonlar = { };
        internal static double[] reyonlarFiyat = { };
         
                           

        internal static void UrunListele()
        {
            
            Console.WriteLine("ÜRÜN LİSTESİ");
            int i = 0;

            while (i < ürünler.Length)
            {
                if (i == 0)
                {
                    
                   
                    Console.WriteLine("GIDA");

                    for (int y = 0; y < ürünler[i].Length; y++)
                    {
                        Console.WriteLine($"{ürünler[i][y]}:{ürünFiyatlar[i][y]}");
                    }
                    i++;
                }
                else if (i == 1)
                {
                   
                    Console.WriteLine("GİYİM");

                    for (int y = 0; y < ürünler[i].Length; y++)
                    {
                        Console.WriteLine($"{ürünler[i][y]}:{ürünFiyatlar[i][y]}");
                    }
                    i++;
                }
                else if (i == 2)
                {
                    
                    Console.WriteLine("BUJİTERİ");

                    for (int y = 0; y < ürünler[i].Length; y++)
                    {
                        Console.WriteLine($"{ürünler[i][y]}:{ürünFiyatlar[i][y]}");
                    }
                    i++;
                }

            }

        }


        internal static void URUNSATISI()
        {
            Console.WriteLine("ÜRÜN SATIŞI");
            while (true)
            {
                try
                {
                    Console.WriteLine("alışverişe devam etmek için-1\nçıkmak için-2\nne yapmak istersiniz ");
                    int cevap = Convert.ToInt32(Console.ReadLine());
                    if (cevap == 1)
                    {
                        try
                        {

                            Console.WriteLine("gıda için-0\ngiyim için-1\nbujiteri için-2\nne istersiniz");
                            int m = Convert.ToInt32(Console.ReadLine());

                            reyonlar = new string[ürünler[m].Length];
                            reyonlarFiyat = new double[ürünFiyatlar[m].Length];
                            Array.Copy(ürünler[m], reyonlar, ürünler[m].Length);
                            Array.Copy(ürünFiyatlar[m], reyonlarFiyat, ürünFiyatlar[m].Length);
                           
                            for (int i = 0; i < reyonlar.Length; i++)
                            {
                                Console.WriteLine($"{reyonlar[i]}:{reyonlarFiyat[i]}TL:               için-{i}");
                            }
                            try
                            {
                                Console.WriteLine("ne istersiniz");
                                n = Convert.ToInt32(Console.ReadLine());
                                if (m == 0)
                                {
                                    alisverisTutari += reyonlarFiyat[n] * 1.2;
                                    Console.WriteLine($"alışveriş tutarı:{alisverisTutari}TL");
                                }
                                else if (m == 1)
                                {
                                    alisverisTutari += reyonlarFiyat[n] * 1.18;
                                    Console.WriteLine($"alışveriş tutarı:{alisverisTutari}TL");
                                }
                                else if (m == 2)
                                {
                                    alisverisTutari += reyonlarFiyat[n] * 1.1;
                                    Console.WriteLine($"alışveriş tutarı:{alisverisTutari}TL");
                                }
                                else
                                {
                                    Console.WriteLine("hatalı işlem");
                                }



                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("rakam giriniz");
                            }








                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("rakam giriniz");
                        }
                    }
                    else if (cevap == 2)
                    {
                        Console.WriteLine("alışveriş tutarı:" + alisverisTutari);
                        Console.WriteLine("yine bekliyoruz");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("rakam giriniz");
                }



            }

        }
        internal static void URUNEKLE()
        {

            Console.WriteLine("ÜRÜN EKLE");
            while (true)
            {
                try
                {
                    Console.WriteLine("ürün eklemeye devam etmek için-1\nçıkmak için-2\nne yapmak istersiniz ");
                    int cevap = Convert.ToInt32(Console.ReadLine());
                    if (cevap == 1)
                    {
                        Console.WriteLine("gıda için-0\ngiyim için-1\nbujiteri için-2\nne istersiniz");
                         m= Convert.ToInt32(Console.ReadLine());
                        Array.Resize(ref ürünler[m], ürünler[m].Length + 1);
                        Array.Resize(ref ürünFiyatlar[m], ürünFiyatlar[m].Length + 1);
                        reyonlar = new string[ürünler[m].Length];
                        reyonlarFiyat = new double[ürünFiyatlar[m].Length];
                        Array.Copy(ürünler[m], reyonlar, ürünler[m].Length);
                        Array.Copy(ürünFiyatlar[m], reyonlarFiyat, ürünFiyatlar[m].Length);
                      
                        
                        Console.WriteLine("eklemek istediğiniz ürünü girin");
                        yeniUrun = Console.ReadLine().ToUpper();
                        reyonlar[reyonlar.Length - 1] = yeniUrun;
                        Console.WriteLine("eklemek istediğiniz ürününün fiyatını  girin");
                        yeniUrunFiyat = Convert.ToInt32(Console.ReadLine());
                        reyonlarFiyat[reyonlarFiyat.Length - 1] = yeniUrunFiyat;
                        Array.Copy(reyonlar, ürünler[m], reyonlar.Length);
                        Array.Copy(reyonlarFiyat, ürünFiyatlar[m], reyonlar.Length);




                    }
                    else if (cevap == 2)
                    {
                        UrunListele();
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("rakam giriniz");
                }
            }
        }
        internal static void URUNSIL()
        {
            Console.WriteLine("ÜRÜN SİL");
            while (true)
            {
                try
                {
                    Console.WriteLine("ürün silmeye devam etmek için-1\nçıkmak için-2\nne yapmak istersiniz ");
                    int cevap = Convert.ToInt32(Console.ReadLine());
                    if (cevap == 1)
                    {
                        try
                        {
                            Console.WriteLine("gıda için-0\ngiyim için-1\nbujiteri için-2\nne istersiniz");
                            int m = Convert.ToInt32(Console.ReadLine());
                            reyonlar = new string[ürünler[m].Length];
                            reyonlarFiyat = new double[ürünFiyatlar[m].Length];
                            Array.Copy(ürünler[m], reyonlar, ürünler[m].Length);
                            Array.Copy(ürünFiyatlar[m], reyonlarFiyat, ürünFiyatlar[m].Length);
                            
                            Console.WriteLine("silmek istediğiniz ürünün indexNo:");
                            int silinecekUrun = Convert.ToInt32(Console.ReadLine());
                            Array.Clear(reyonlar, silinecekUrun, 1);
                            Array.Clear(reyonlarFiyat, silinecekUrun, 1);
                            Array.Copy(reyonlar, ürünler[m], reyonlar.Length);
                            Array.Copy(reyonlarFiyat, ürünFiyatlar[m], reyonlarFiyat.Length);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("rakam giriniz");
                        }

                    }
                    else if (cevap == 2)
                    {
                        Console.WriteLine("çıkış yaptınız");
                        UrunListele();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("rakam giriniz");
                }
            }
        }
        internal static void URUNGUNCELLEME()
        {
            Console.WriteLine("ÜRÜN GÜNCELLEME");
            while (true)
            {
                try
                {
                    Console.WriteLine("ürün güncellemeye devam etmek için-1\nçıkmak için-2\nne yapmak istersiniz ");
                    int cevap = Convert.ToInt32(Console.ReadLine());
                    if (cevap == 1)
                    {
                        try
                        {
                            Console.WriteLine("gıda için-0\ngiyim için-1\nbujiteri için-2\nne istersiniz");
                            int m = Convert.ToInt32(Console.ReadLine());
                            reyonlar = new string[ürünler[m].Length];
                            reyonlarFiyat = new double[ürünFiyatlar[m].Length];
                            Array.Copy(ürünler[m], reyonlar, ürünler[m].Length);
                            Array.Copy(ürünFiyatlar[m], reyonlarFiyat, ürünFiyatlar[m].Length);
                           
                            Console.WriteLine("güncellemek  istediğiniz ürünün indexNo:");
                            guncellenecekUrun = Convert.ToInt32(Console.ReadLine().ToUpper());
                            Console.WriteLine("ürününüzü güncelleyin");
                            reyonlar[guncellenecekUrun] = Console.ReadLine();
                            Console.WriteLine("güncellenmiş ürünün fiyatını girin:");
                            reyonlarFiyat[guncellenecekUrun] = Convert.ToInt32(Console.ReadLine());
                            Array.Copy(reyonlar, ürünler[m], reyonlar.Length);
                            Array.Copy(reyonlarFiyat, ürünFiyatlar[m], reyonlarFiyat.Length);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("rakam giriniz");
                        }
                    }
                    else if (cevap == 2)
                    {
                        Console.WriteLine("çıkış yaptınız");
                        UrunListele();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("rakam giriniz");
                }
            }
        }
    }
}
