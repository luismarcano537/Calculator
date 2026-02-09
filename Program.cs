namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("========== Menu ==========");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.Write("Selecione uma opção: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: break;
            }
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
            Menu();
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
            Menu();
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
            Menu();
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
            Menu();
        }
    }
}