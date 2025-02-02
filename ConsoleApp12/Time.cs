using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Time
    {
        public int hour;
        public int minute;
        public int second;
        public Time() { }
        public Time(int hour)
        {
            this.hour = hour;
        }
        public Time(int hour, int minute) :this(hour)
        {
            this.minute = minute;
        }
        public Time(int hour,int minute, int second) :this(hour,minute)
        {
            this.second = second;
        }

        public int Timeminute()
        {
            int rez = hour * 60;
            int rez2 = rez + minute;
            return rez2 * 60 + second;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Часы: {hour}\t Минуты: {minute}\t Секунды: {second}\t Результат: {Timeminute()} секунд");
        }
        public string Tostring()
        {
            return $"Часы: {hour}\t Минуты: {minute}\t Секунды: {second}\t Результат: {Timeminute()} секунд";
        }

    }
}
