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

            Triangle triangle1 = new Triangle(5, 6); // instansiering av triangel klassen för uträkning av arean när man vet längden på två sidor samt har en 90 gradig vinkel mellan dem.

            Console.WriteLine($"\nThe area of a triangle with the base length 5 and height 6 is: {triangle1.GetArea2sides()} units");

        }
    }
}