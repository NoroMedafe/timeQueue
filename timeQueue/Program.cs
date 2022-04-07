using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOfReceipt = 10;
            int queueLenght;
            const int MinutesInAnHour = 60;
            int timeInLine;
            int countHours;
            int countMinutes;

            Console.Write("Введите количество людей в очереди: "); queueLenght = Convert.ToInt32(Console.ReadLine());
            timeInLine = timeOfReceipt * queueLenght;
            countHours = timeInLine / hour;
            countMinutes = timeInLine % hour;
            Console.WriteLine($"Вы должны отстоять в очереди {countHours} часа и {countMinutes} минут");
            Console.ReadKey();
        }
    }
}
