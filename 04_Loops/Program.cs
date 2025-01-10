using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğniz adeti giriniz: ");
            //int finishvalue= int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}


            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda: " +bacterium);
            //}





            #endregion


            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;


            Console.WriteLine(ones+ " - " + tens+" - " + hundreds);
            sum = ones+tens+hundreds;
            Console.WriteLine(sum);

            Console.Read();
        }
    }
}
