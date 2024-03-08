using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab5
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() 
        {
            Console.WriteLine("Invalid Radius: radius must be greater than 0.");
        }

        public InvalidRadiusException(double radius)
        {
            Console.WriteLine($"Invalid Radius {radius}: radius must be greater than 0.");
        }
    }
}
