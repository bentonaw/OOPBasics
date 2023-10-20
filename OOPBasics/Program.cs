namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); // första instansieringen av cirkel klassen med radie 5
            Circle circle2 = new Circle(6); // andra instansieringen av cirkel klassen med radie 6

            Console.WriteLine($"Area for the first circle with radius 5 is: {circle1.GetArea()} cm²");
            Console.WriteLine($"Circumference: {circle1.GetCircumference()} cm");
            Console.WriteLine($"Volume: {circle1.GetVolume()} cm³");
            
            Console.WriteLine($"\nArea for the second circle with radius 5 is: {circle2.GetArea()} cm²");
            Console.WriteLine($"Circumference: {circle2.GetCircumference()} cm");
            Console.WriteLine($"Volume: {circle2.GetVolume()} cm³");

            Console.WriteLine("\nTo calculate the area of a triangle I will need the length of the base and height (length of the longest line perpendicular to the base)");
            Triangle triangle1 = new Triangle();

            Console.Write("Length of a: ");
            triangle1.A = double.Parse(Console.ReadLine());
            Console.Write("Length of b: ");
            triangle1.B = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of the triangle is " + triangle1.GetArea2sides() + " units");

        }
    }
}