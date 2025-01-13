using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Geriye değer döndürmeye metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Değer Döndürmeyen parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ayşe Demir");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Emre", "Pala");

            #endregion

            #region Değer Döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4,5,6);

            #endregion

            #region Değer Döndüren  metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " "+surname;
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Değer Döndüren parametreli metotlar

            string CountryCard(string countryName, string countryCapital,string flagColor)
            {
                string cardInfo ="Ülke: " +countryName+" -Başkent: "+countryCapital+" -Bayrak Rengi: "+flagColor;
                return cardInfo;
            }

            string x, y, z;
            Console.Write("Ülke Adını Giriniz: ");
            x = Console.ReadLine();

            Console.Write("Başkenti Giriniz: ");
            y = Console.ReadLine();

            Console.Write("Bayrak Rengini Giriniz: ");
            z = Console.ReadLine();

            CountryCard(x, y, z);
            Console.WriteLine(CountryCard(x, y, z));
            #endregion

            Console.Read();
        }
    }
}
