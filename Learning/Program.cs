using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Car
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем со скоростью {speed} км\\ч");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {speed} км\\ч");
            }
        }
        public void DriveForward()
        {
            speed = 60;
        }
        public void Stop()
        {
            speed = 0;
        }
        public void DriveBackward()
        {
            speed = -5;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t== Car 1 ==");
            var car = new Car();
            car.PrintSpeed();
            car.DriveForward();
            car.Stop();
            car.DriveBackward();
        }
    }
}
