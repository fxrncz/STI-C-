namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5;
            double res;

            Console.WriteLine("Enter 5 grades separated by new line: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            num4 = Convert.ToDouble(Console.ReadLine());
            num5 = Convert.ToDouble(Console.ReadLine());

            res = num1 + num2 + num3 + num4 + num5;
            double avrg = res / 5;
            
            Console.WriteLine("The average is " + avrg + " and round off to " + Math.Round(avrg));
        }
    }
}