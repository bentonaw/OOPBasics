namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); // first object of circle class with radius 5
            Circle circle2 = new Circle(6); // second object of circle class with radius 6

            Console.WriteLine($"Area for the first circle with radius 5 is: {circle1.GetArea()} cm²");
            Console.WriteLine($"Circumference: {circle1.GetCircumference()} cm");
            Console.WriteLine($"Volume: {circle1.GetVolume()} cm³");
            
            Console.WriteLine($"\nArea for the second circle with radius 5 is: {circle2.GetArea()} cm²");
            Console.WriteLine($"Circumference: {circle2.GetCircumference()} cm");
            Console.WriteLine($"Volume: {circle2.GetVolume()} cm³");

            Triangle triangle1 = new Triangle(5, 6); // instance of triangle class to get area where two sides are known and the angle between them is 90 degrees.

            Console.WriteLine($"\nThe area of a triangle with the base length 5 and height 6 is: {triangle1.GetArea2sides()} units");

        }
    }
}