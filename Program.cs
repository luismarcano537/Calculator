namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            
            float result = firstValue + secondValue;

            Console.WriteLine($"A soma dos valores informados é: {result}");
        }
    }
}