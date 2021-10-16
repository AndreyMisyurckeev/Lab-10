using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = 0;
            int min = 0;
            int sec = 0;
            double toRadian=0;
            Angle angle = new Angle(gradus, min, sec,toRadian);
            angle.ToRadian();
            Console.ReadKey();
        }
    }
    public class Angle
    {
        public int gradus;
        public int min;
        public int sec;
        public int startValue;
        public double toRadian;

        public Angle(int Gradus, int Min, int Sec, double ToRadian)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
            ToRadian = toRadian;
        }
        public void ToRadian()
        {
            Console.Write("Введите значение gradus - ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            if (gradus >= 0 && gradus < 360)
            {
            }
            else
            {
                Console.WriteLine("Введено некорректное значение gradus");
            }
            Console.Write("Введите значение min - ");
            int min = Convert.ToInt32(Console.ReadLine());
            if (min >= 0 && min <= 60)
            {
            }
            else
            {
                Console.WriteLine("Введено некорректное значение min - ");
            }
            Console.Write("Введите значение sec - ");
            int sec = Convert.ToInt32(Console.ReadLine());
            if (sec >= 0 && sec <= 60)
            {
            }
            else
            {
                Console.WriteLine("Введено некорректное значение sec");
            }
            double toRadian = (double)((Math.PI * gradus / 180) + (Math.PI * min / (180 * 60)) + (Math.PI * sec / (180 * 60 * 60)));
            Console.WriteLine($"Значение введенного угла равняется {toRadian:F} радиан.");
        }
    }
}
