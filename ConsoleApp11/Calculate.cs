using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Calculate
    {

        public double Number1;
        public double Number2;
        public double rez;
        public Calculate(){}
        public Calculate(double Number1)
        {
            this.Number1 = Number1;
        }
        public Calculate(double Number1,double Number2) :this(Number1)
        {
            this.Number2 = Number2;
        }
        
        public double Calculatekoren()
        {
            return Math.Sqrt(Number1 * Number2);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Первое число: {Number1}\t второе число: {Number2}\t Результат{Calculatekoren():f2}");
        }
        public string Tostring()
        {
            return $"Первое число: {Number1}\t второе число: {Number2}\t Результат{Calculatekoren():f2}";
        }
    }
}
