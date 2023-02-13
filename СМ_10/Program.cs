using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_10
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Введите последовательно градусы,минуты,секунды угла");
            double gradus_ = Convert.ToInt32(Console.ReadLine());
            double min_ = Convert.ToInt32(Console.ReadLine());
            double sec_ = Convert.ToInt32(Console.ReadLine());

            Ugol ugol = new Ugol (gradus_, min_, sec_);
            
            double totalRadians = ugol.ToRadians();
            Console.WriteLine("Абсолютное значение радиан {0:f3}",totalRadians);
            Console.ReadKey();
        }
    }
}
