using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поликлиника2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int visitors;
            int waitingTimeVisitorInMinuts = 10;
            int waitingTimeInMinuts;
            int minutInHour;
            int hour;
            int overMinuts;

            Console.WriteLine($"время приема посетителя:{waitingTimeVisitorInMinuts} минут");
            Console.Write("Сколько человек в очереди?");
            visitors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сколько минут в одном часе?");
            minutInHour = Convert.ToInt32(Console.ReadLine());

            waitingTimeInMinuts = visitors * waitingTimeVisitorInMinuts;
            hour = waitingTimeInMinuts / minutInHour;
            overMinuts = waitingTimeInMinuts % minutInHour;

            Console.WriteLine($"время ожидания {hour} часов и {overMinuts} минут");
        }
    }
}
