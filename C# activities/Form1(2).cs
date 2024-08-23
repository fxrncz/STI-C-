namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("---- FIRST METHOD OF MATH CLASS ----");
            Console.WriteLine("====================================");
            Console.WriteLine("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // POWER MATH.METHOD
            Console.WriteLine("The result is: " + Math.Pow(num1, num2) + "\n");

            Console.WriteLine("====================================");
            Console.WriteLine("---- SECOND METHOD OF MATH CLASS ----");
            Console.WriteLine("====================================");

            Console.WriteLine("Enter number 1: ");
            double num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            double num5 = Convert.ToInt32(Console.ReadLine());

            double res = num4 + num5;
            double avrg = res / 2;

            // ROUND-OFF MATH.METHOD
            Console.WriteLine("The round off of the average result is: " + Math.Round(avrg) + "\n");

            Console.WriteLine("====================================");
            Console.WriteLine("---- THIRD METHOD OF MATH CLASS ----");
            Console.WriteLine("====================================");

            Console.WriteLine("Enter number 1: ");
            double num6 = Convert.ToInt32(Console.ReadLine());

            // SQUARE ROOT MATH.METHOD
            Console.WriteLine("The square root of your given number is: " + Math.Sqrt(num6) + "\n");

            Console.WriteLine("====================================");
            Console.WriteLine("---- FOURTH METHOD OF MATH CLASS ----");
            Console.WriteLine("====================================");

            Console.WriteLine("Enter number 1: ");
            double num7 = Convert.ToInt32(Console.ReadLine());

            // SINE MATH.METHOD
            Console.WriteLine("The value of the sine specified angle is: " + Math.Sin(num7) + "\n");

            Console.WriteLine("====================================");
            Console.WriteLine("---- FIFTH METHOD OF MATH CLASS ----");
            Console.WriteLine("====================================");

            Console.WriteLine("Enter number 1: ");
            double num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");

            // TANGENT MATH.METHOD
            Console.WriteLine("The value of the tangent specified angle is: " + Math.Tan(num8) + "\n");
        }
    }
}