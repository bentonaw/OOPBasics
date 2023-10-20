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

            Console.WriteLine("\nTo calculate the area of a triangle we will need to start with which information you have on the triangle: " +
                "\n1. Length of two side (a+b)" +
                //"\n2. Lengths of all sides (a+b+c)" +
                //"\n3. Lengths of two sides (a+b) and the angle between them(θ)" +
                //"\n4. Quit");
            //"\n4. Two angles(θ1+θ2) and the length between them(a)"); // Skippar detta för tillfället

            Triangle triangle1 = new Triangle();

            Console.Write("\nPlease select an option between 1-4: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Length of a: ");
                    triangle1.A = double.Parse(Console.ReadLine());
                    Console.Write("Length of b: ");
                    triangle1.B = double.Parse(Console.ReadLine());

                    Console.WriteLine(triangle1.GetArea2sides());
                    
                    break;
                //case 2:
                //    Console.Write("Length of a: ");
                //    triangle1.A = double.Parse(Console.ReadLine());
                //    Console.Write("Length of b: ");
                //    triangle1.B = double.Parse(Console.ReadLine());
                //    Console.Write("Length of c: ");
                //    triangle1.C = double.Parse(Console.ReadLine());

                //    Console.WriteLine(triangle1.GetArea3sides());
                //    break;
                //case 3:
                //    Console.Write("Length of a: ");
                //    triangle1.A = double.Parse(Console.ReadLine());
                //    Console.Write("Length of b: ");
                //    triangle1.B = double.Parse(Console.ReadLine());
                //    Console.Write("Angle between a and b: ");
                //    triangle1.Angle1 = double.Parse(Console.ReadLine());

                //    Console.WriteLine(triangle1.GetArea2sides1Angle());
                //    break;
                //case 4:
                //    Console.Write("First angle (Y): ");
                //    triangle1.θ1 = double.Parse(Console.ReadLine());
                //    Console.Write("Second Angle (β): ");
                //    triangle1.θ2 = double.Parse(Console.ReadLine());
                //    Console.Write("Length between the angles: ");
                //    triangle1.a = double.Parse(Console.ReadLine());
                //    break;
                default:
                    break;
            }




        }
    }
}