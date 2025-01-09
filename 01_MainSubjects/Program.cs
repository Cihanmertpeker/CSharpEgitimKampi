using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Selam");
            //Console.Write("Merhaba Dünya");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion


            #region Degiskenler

            //string name;
            //name = "Cihan";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 300 30 30";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("Email Adresi: " +customerEmail);
            //Console.WriteLine("Adres: " + district + " " + city);
            //Console.WriteLine("--------------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 300 20 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " " + city);
            //Console.WriteLine("--------------------------------------------------");

            #endregion


            #region int Degiskenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterprice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("******* Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("_____Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("_____Pizza: " +pizzaPrice + " TL ");
            Console.WriteLine("_____Kola: " + cokePrice + " TL ");
            Console.WriteLine("_____Limonata: " +lemonadePrice + " TL ");
            Console.WriteLine("_____Kızartma: " +friesPrice + " TL ");
            Console.WriteLine("_____Su: " +waterprice + " TL ");
            Console.WriteLine("******* Restoran Menü Fiyatı *****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int watercount;
            int friescount;
            int pizzaCount;
            int lemonadecount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterprice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            watercount = 3;
            friescount = 1;
            pizzaCount = 0;
            lemonadecount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterprice = watercount * waterprice;
            totalFriesPrice = totalFriesPrice + friescount;
            totalPizzaPrice = pizzaCount * pizzaCount;
            totalLemonadePrice = lemonadecount * lemonadePrice;


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı: "+totalHamburgerPrice+ " TL");
            Console.WriteLine("Pizza Tutarı: "+totalPizzaPrice+ " TL");
            Console.WriteLine("Kızartma Tutarı: "+totalFriesPrice+ " TL");
            Console.WriteLine("Kola Tutarı: "+totalCokePrice+ " TL");
            Console.WriteLine("Su Tutarı: "+totalWaterprice+ " TL");
            Console.WriteLine("Limonata Tutarı: "+totalLemonadePrice+ " TL");


            int totalPrice =  totalCokePrice+ totalWaterprice+totalFriesPrice+totalLemonadePrice+totalHamburgerPrice+totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: "+totalPrice +" TL");

            #endregion

            Console.Read();
        }
    }
}
