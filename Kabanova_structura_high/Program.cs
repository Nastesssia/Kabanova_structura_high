using System;

namespace Kabanova_structura
{
    class Program
    {
        struct Speed
        {
            public int number;
            public string arrtime;
            public string departime;
            public string direction;
            public int distance;
        }
        static void Main(string[] args)
        {
            Speed[] speedtrain = new Speed[5];
            for (int i = 0; i < speedtrain.Length; i++)
            {
                Console.Write("Введите №(номер) " + (i + 1) + " поезда: ");
                speedtrain[i].number = int.Parse(Console.ReadLine());
                Console.Write("Введите время его прибытия: ");
                speedtrain[i].arrtime = Console.ReadLine();
                Console.Write("Введите время его отбытия: ");
                speedtrain[i].departime = Console.ReadLine();
                Console.Write("Введите направление поезда: ");
                speedtrain[i].direction = Console.ReadLine();
                Console.Write("Введите расстояние маршрута в км: ");
                speedtrain[i].distance = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            foreach (Speed item in speedtrain)
            {
                string[] dt = item.departime.Split(".");
                double dthour = double.Parse(dt[0]);
                double dtmin = double.Parse(dt[1]);
                string[] at = item.arrtime.Split(".");
                double athour = double.Parse(at[0]);
                double atmin = double.Parse(at[1]);
                double average = item.distance / ((athour - dthour) + ((atmin - dtmin) / 60));
                Console.WriteLine("Средняя скорость " + average + " км/ч");
            }
        }
    }
}
