using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //int[] numbers = {45,78,985,635,74,11,22,33,41,205,6578,10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = {45,78,985,635,74,11,22,33,41,205,6578,10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int number in numbers) { total += number; }
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Örnek Sınav Sistemi

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} Adlı öğrencinin {j + 1}. sınav notunuz giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExamResult / 3;
            }

            //Sınav ortalamarı
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAverage[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı ögrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı ögrenci dersten kaldı.");
                }


            }

            #endregion

            Console.Read();
        }
    }
}
