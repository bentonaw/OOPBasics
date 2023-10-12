namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine("Area for the first circle with radius 5 is " + circle1.GetArea());
            Console.WriteLine("Area for the first circle with radius 6 is " + circle2.GetArea());
        }
    }
}