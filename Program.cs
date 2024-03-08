// See https://aka.ms/new-console-template for more information

using CPRG211Lab5;

try
{
    Circle circle1 = new Circle(2.1);
    Console.WriteLine(circle1);
}
catch (InvalidRadiusException) { } //the exception's constructor prints the error message so the catch block doesn't need to.

try
{
    Circle circle2 = new Circle(-2.1);
    Console.WriteLine(circle2);
}
catch (InvalidRadiusException) { }

try
{
    Circle circle3 = new Circle(0);
    Console.WriteLine(circle3);
}
catch (InvalidRadiusException) { }