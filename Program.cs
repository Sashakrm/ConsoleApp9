using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        /// <summary>
        ///  ввод и вывод данных
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("введите двухзначное число");
            int number = int.Parse(Console.ReadLine());
            int tens, unit;
            Cifra(number, out tens, out unit);
            ///метод out я вычитал в интернете
            double proizv = Proiz(tens, unit);
            double plus = Plus(tens, unit);
            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {unit}");
            Console.WriteLine($"Сумма цифр: {plus}"); 
            Console.WriteLine($"Произведение цифр: {proizv}");
            Console.WriteLine($"Перемена мест: {unit}{tens}");
            Console.Read();
        }
        /// <summary>
        /// разделение на единицы и десятки
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static void Cifra(int number, out int tens, out int unit)
        {
            tens = number / 10;
            unit = number % 10;
        }
        /// <summary>
        /// складываем
        /// </summary>
        /// <param name="tens"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        static double Plus(double tens, double unit)
        {
            return tens + unit;
        }
        /// <summary>
        /// умножаем
        /// </summary>
        /// <param name="tens"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        static double Proiz (double tens, double unit)
        {
            return tens * unit;
        }
    }
}
