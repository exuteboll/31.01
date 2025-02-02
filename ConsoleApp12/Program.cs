using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.hour = 1;
            time.minute = 120;
            time.second = 500;
            time.ShowInfo();
            Time time2 = new Time(15,25, 200);
            Console.WriteLine($"{time2.Tostring()}");
            Console.WriteLine("Введите часы: ");
            int hour1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минуты: ");
            int minute1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите секунды: ");
            int second1 = int.Parse(Console.ReadLine());
            Time time3 = new Time(hour1, minute1,second1);
            Console.WriteLine($"{time3.Tostring()}");
            Console.ReadKey();
        }
    }
}
