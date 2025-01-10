using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //double exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması: "+average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average>70 & average<= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.Write(result);

            //string city;
            //Console.Write("Lütfen Şehir girişi yapınız");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{ Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2.sayıya bölümünden kalan: "+result);
            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;
            Console.Write("1. Sayıyı Giriniz: ");
            number1= int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol= char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1+number2;
                    Console.WriteLine("Toplam: "+result);
                    break;

                case '-':
                    result = number1 - number2;

                    Console.WriteLine("Fark: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            }


            #endregion

            Console.Read();
        }

    }
}
