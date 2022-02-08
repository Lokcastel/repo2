using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp196
{
    internal class Car
    {
        // 1.  costruttore -> expression-bodied member


        public int currSpeed;
        public Car()
        {
        }


        /*// 1
        public Car(string speed)
        {
            currSpeed = speed;
        }
        */

        // 2
        public Car( int speed ) => currSpeed = speed;
        


        // Method to display currSpeed
        public void displayCar()
        {
            Console.WriteLine($" speed: {currSpeed}");
        }

        // Method -> expression-bodied member

        public void speedUp() => currSpeed += 10;
    }
}
