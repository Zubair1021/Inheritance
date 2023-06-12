using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7Cs
{
    class Program
    {
        /* -----------------------------FireFighter Classes Implemeted (Inheritance)-----------------------------------------*/
        public class ladder
        {
            private int length;
            private string color;

            public void setlength(int length)
            {
                this.length = length;
            }
            public void setcolor(string color)
            {
                this.color = color;
            }
            public int getlength()
            {
                return length;
            }
            public string getcolor()
            {
                return color;
            }
        }
        public class hosePipe
        {
            private string material;
            private string shape;
            private float diameter;
            private float flowrate;

            public hosePipe(string material, string shape, float diameter, float flowrate)
            {
                this.material = material;
                this.shape = shape;
                this.diameter = diameter;
                this.flowrate = flowrate;
            }
        }
        public class firefighter
        {
            private string name;
            public void setname(string name)
            {
                this.name = name;
            }
            public string getname()
            {
                return name;
            }
            public void drive()
            {
                Console.WriteLine(name + "is driving a car");

            }
            public void extinguishfire()
            {
                Console.WriteLine(name + "is extinguishing fire ");

            }

        }
        public class firechief : firefighter
        {
            public void delegaterespo(string firename)
                {
                Console.WriteLine("tell" + firename + "to extinguish fire");
                }
         }

        public class firetruck
        {
            private ladder l1;
            private hosePipe h1;
            private firefighter driver;
        }

        /* -----------------------------Bicycle Classes Implemeted (Inheritance)-----------------------------------------*/

        public class bicycle
        {
            private int cadence;
            private int gear;
            private int speed;

            public bicycle(int cadence,int gear,int speed)
            {
                this.cadence = cadence;
                this.gear = gear;
                this.speed = speed;
            }
             public void setcadence(int cadence)
            {
                this.cadence = cadence;
            }
            public void setgear(int gear)
            {
                this.gear = gear;
            }
            public void applybrake(int decrement)
            {
                int result = speed - decrement;
                if (result >= 0 && result <= 120)
                    Console.WriteLine("Your speed is " + result);
                else
                    Console.Write("Invalid Decrement in speed");
            }
            public void speedup(int increament)
            {
               
                    int result = speed + increament;
                if (result >= 0 && result <= 120)
                    Console.WriteLine("Your speed is " + result);
                else
                    Console.Write("Invalid increment  in speed");
            }
        }

        public class MountainBike : bicycle
        {
            private int seatHeight;
            
            public MountainBike(int seatHeight, int cadence ,int speed ,int gear) : base (cadence,gear,speed)
            {
                this.seatHeight = seatHeight;
            }
            public void setSeatHeight(int seatHeight)
            {
                this.seatHeight = seatHeight;
            }
        }
  

    static void Main(string[] args)
        {
            // now we call these classes and run this classes for checkup the classes is implememted

            Console.ReadKey();
        }
    }
}
