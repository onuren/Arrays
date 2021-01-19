using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tanımlama
            ////aynı türden belirli sayıda değeri bir arada tutulmasını sağlayan yapıdır.
            //int[] sayilar = new int[5];
            //sayilar[1] = 123;
            //sayilar[0] = -456;
            //sayilar[4] = 481;
            //Console.WriteLine(sayilar[4]);

            //Console.WriteLine(sayilar.Length);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            #endregion

            #region 

            ////string[] isimler = new string[3];
            ////isimler[0] = "ibrahim";
            ////isimler[1] = "alp";
            ////isimler[2] = "Şuayip";

            //string[] isimler = {"ibrahim","alp","şuayip"};

            //for (int i=0;i<isimler.Length;i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}



            #endregion

            int[] sayilar = { 5, 13, -5, 158, -78, 10, 6, 199, 73, 44 };

            #region dizi içerisindeki çift sayıları yazdır

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if(sayilar[i]%2==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            #endregion

            #region negatif sayıları yazdır

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if(sayilar[i]<0)
            //        Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region en büyük sayı

            //int enbuyuk = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]>enbuyuk)
            //    {
            //        enbuyuk = sayilar[i];
            //    }
            //}
            //Console.WriteLine(enbuyuk);

            #endregion

            #region en küçük sayı

            //int enkucuk = sayilar[0];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < enkucuk)
            //    {
            //        enkucuk = sayilar[i];
            //    }
            //}
            //Console.WriteLine(enkucuk);
            #endregion

            #region sayıların ortalaması
            //int top=0;
            //int ort=0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    top += sayilar[i];
            //    ort = top / sayilar.Length;
            //}
            //Console.WriteLine(ort);

            #endregion

            #region eleman sayısını yazdırın

            //Console.WriteLine(sayilar.Length);

            #endregion

            #region string dizi

            //string isim = "İbrahim Alp Sarıkışla";
            //Console.WriteLine(isim.Length);

            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine(isim[i]);
            //}

            ////isim[5] = 'a'; Atama yapılamaz.

            #endregion

            #region kullanıcıdan alınan isim uzunluğu 10 karakterden düşükse merhaba "isim" büyükse isim alanı 10 karakterdir desin

            //Console.WriteLine("isim giriniz");
            //string isim = Console.ReadLine();
            //if(isim.Length<=10)
            //{
            //    Console.WriteLine("merhaba "+isim);
            //}
            //else
            //{
            //    Console.WriteLine("isim uzunluğu 10 karakter olmalıdır");
            //}

            #endregion

            #region  kaç büyük karakter var




            #endregion

            #region büyük karakterleri yazdır

            //string sehir = "EsKisEhiR";
            //char[] sehirchr = new char[sehir.Length];
            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    sehirchr[i] = sehir[i];
            //    if (sehirchr[i] >= 65 && sehirchr[i] <= 90)
            //    {
            //        Console.WriteLine(sehirchr[i]);
            //    }
            //}

            #endregion

            #region uygulama
            ////karakter sayısı 6 üstü olan şehirleri yazınız

            //string[] sehirler = { "ankara", "eskişehir", "izmir", "kastamonu", "manisa", "bursa", "çanakkale" };

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    if(sehirler[i].Length > 6)
            //    {
            //        Console.WriteLine(sehirler[i]);
            //    }
            //}

            #endregion

            #region uygulama
            ////tüm karakterleri büyütün

            //string isim = "mustafa";
            //int isimint = 0;
            //string isim2="";

            //for (int i = 0; i < isim.Length; i++)
            //{
            //    isimint = Convert.ToInt32(isim[i]);
            //    isimint -= 32;
            //    isim2 += Convert.ToChar(isimint);

            //}
            //Console.WriteLine(isim2);

            #endregion

            #region uygulama
            //Console.WriteLine("kelime giriniz");
            //string kelime = Console.ReadLine();
            //string ters = "";

            //for (int i = kelime.Length; i >0; i--)
            //{
            //    ters += kelime[i-1];
            //}
            //if(kelime==ters)
            //{ Console.WriteLine("poligromiktir."); }
            //else { Console.WriteLine("değildir."); }

            #endregion

            #region uygulama

            //dizideki en büyük sayı ile en küçük sayının toplamı
            int enbuyuk = sayilar[0];
            int enkucuk = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enbuyuk)
                {
                    enbuyuk = sayilar[i];
                }
                if (sayilar[i] < enkucuk)
                {
                    enkucuk = sayilar[i];
                }
            }
            Console.WriteLine(enbuyuk + enkucuk);

            #endregion
        }
    }
}
