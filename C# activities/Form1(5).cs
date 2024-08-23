namespace DataTypeApp
{
    internal class DataTypeProgram
    {
        static void Main(string[] args)
        {
            string stringWord = "Hello, World!";
            int numberValue = 100;

            Console.Write("Enter a Double Value: ");
            double doubleValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a UInt Value: ");
            uint UintValue = Convert.ToUInt32((Console.ReadLine()));

            Console.Write("Enter a Byte Value: ");
            byte byteValue = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\n============================================\n");

            // Constant Value
            Console.WriteLine("The String Value: " + stringWord);
            Console.WriteLine("The Integer Value: " + numberValue);

            // User-end Value
            Console.WriteLine("The Double Value: " + doubleValue);
            Console.WriteLine("The UInt Value: " + UintValue);
            Console.WriteLine("The Byte Value: " + byteValue);
        }
    }
}