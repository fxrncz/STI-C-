namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the piece of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter total price of " + pieces + " apple(s): ");
            double tlprice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The total price of " + pieces + " apple(s) is " + tlprice);
            Console.WriteLine("The value of original price is " + tlprice);

            int converted = (int)tlprice;

            Console.WriteLine("The value of converted price is " + converted);
        }
    }
}