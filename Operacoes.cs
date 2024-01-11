namespace SimpleCalculator
{
    internal class Operacoes
    {
        public static void Adicao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            int numeroUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numeroDois = int.Parse(Console.ReadLine());
            int resultado = numeroUm + numeroDois;
            Console.WriteLine($"A soma entre {numeroUm} e {numeroDois} é igual a {resultado}");
            Console.Write("Pressione qualquer tecla para prosseguir ");
            Console.ReadKey();
            Program.TelaFinal();
        }
        public static void Subtracao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            int numeroUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numeroDois = int.Parse(Console.ReadLine());
            int resultado = numeroUm - numeroDois;
            Console.WriteLine($"A subtração entre {numeroUm} e {numeroDois} é igual a {resultado}");
            Console.Write("Pressione qualquer tecla para prosseguir ");
            Console.ReadKey();
            Program.TelaFinal();
        }
        public static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            int numeroUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numeroDois = int.Parse(Console.ReadLine());
            int resultado = numeroUm * numeroDois;
            Console.WriteLine($"A multiplicação entre {numeroUm} e {numeroDois} é igual a {resultado}");
            Console.Write("Pressione qualquer tecla para prosseguir ");
            Console.ReadKey();
            Program.TelaFinal();
        }
        public static void Divisao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            double numeroUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double numeroDois = int.Parse(Console.ReadLine());
            double resultado = numeroUm / numeroDois;
            Console.WriteLine($"A divisão entre {numeroUm} e {numeroDois} é igual a {resultado:F2}");
            Console.Write("Pressione qualquer tecla para prosseguir ");
            Console.ReadKey();
            Program.TelaFinal();
        }
    }
}
