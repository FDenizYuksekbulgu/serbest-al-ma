
using System;

class Program
{
    // 1- Geriye Değer Döndürmeyen Bir void metot.
    static void sarkiSözü()
    {
        Console.WriteLine("N'apim tabiatım böyle!");
    }


} 

using System;

class Program
{
    //2-Geriye Tamsayı Döndüren Bir metot
    static void RastgeleSayidanKalan()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 10);  // 1 ile 100 arasında rastgele bir sayı üretir
        int kalan = sayi % 2;  // Sayının 2'ye bölümünden kalan


        Console.WriteLine($"Sayı: {sayi}");
        Console.WriteLine($"Sayının 2'ye bölümünden kalan: {kalan}");
    }

    static void Main()
    {
        // Rastgele sayının (mod2)'si
        RastgeleSayidanKalan();
    }
}


using System;

class Program
{
     4- Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
    static void HosgeldinizMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}!");
    }

    static void Main()
    {

        Console.Write("İsminizi giriniz: ");
        string isim = Console.ReadLine();

        Console.Write("Soyadınızı giriniz: ");
        string soyisim = Console.ReadLine();

        Kullanıcıya adı ve soyadını kullarak hoş geldiniz mesajı yazdırıyoruz.
       HosgeldinizMesaji(isim, soyisim);
    }
}

