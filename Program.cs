namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Sum();
            Subtract();
            Division();
            Multiplication();
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Soma: ");
            Console.Write("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            
            float result = firstValue + secondValue;

            Console.WriteLine($"A soma dos valores informados é: {result}");
            Console.ReadKey();
        }

        static void Subtract()
        {
            Console.Clear();
            Console.WriteLine("Subtração: ");
            Console.Write("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            
            float result = firstValue - secondValue;

            Console.WriteLine($"A subtração dos valores informados é: {result}");
            Console.ReadKey();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Divisão: ");
            Console.Write("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            
            float result = firstValue / secondValue;

            Console.WriteLine($"A divisão dos valores informados é: {result}");
            Console.ReadKey();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Multiplicacao: ");
            Console.Write("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            
            float result = firstValue * secondValue;

            Console.WriteLine($"A multiplicação dos valores informados é: {result}");
            Console.ReadKey();
        }
    }
}