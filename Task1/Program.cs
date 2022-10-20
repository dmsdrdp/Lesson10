using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corner corner = new Corner();
            try
            {
                Console.WriteLine("Введите данные");
                corner.Gradus = Convert.ToDouble(Console.ReadLine());
                corner.Min = Convert.ToDouble(Console.ReadLine());
                corner.Sec = Convert.ToDouble(Console.ReadLine());

                corner.decimalDegree = 0;

                double radians = corner.ToRadians();
                Console.WriteLine("{0} радиан", radians);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
