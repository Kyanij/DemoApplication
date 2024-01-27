using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    public class Car
    {
        string color; //field private  Encapsulation 

        public string SetColor { set { color = value; } } // properties
        public string GetColor { get; }

        public Car()
        {
            color = "red";
        }

        public Car(string col) //constructor initialize value
        {
            color = col;
        }
        public void Drive()  //function/ method
        {
            Console.WriteLine("Drive method called");
        }
    }


}

//Create a 
