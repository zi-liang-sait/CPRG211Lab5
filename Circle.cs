using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab5
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle() 
        {
            this.Radius = 1;
        }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException(radius);
            }
            Radius = radius;
        }

        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException(radius);
            }
            this.Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle of radius {Radius}";
        }
    }
}
