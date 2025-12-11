using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSAROSO
{
    public class Shape
    {
        //Base class
        public string Color {  get; set; }

        public Shape (string color)
        {
            Color = color;  
        }

        //Virtual method for Shape
        public virtual double GetArea()
        {
            return 0;
        }

        //Derived class

        
    }
    public class Circle : Shape
    {
        //Base class
        public double Radius { get; set; }

        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        //Virtual method for Shape
        public virtual double GetArea()
        {
            return 0;
        }
    }
    
}
