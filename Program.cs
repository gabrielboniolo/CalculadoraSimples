namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaInicial();
        }
        public static void TelaInicial()
        {
            Console.WriteLine("Olá, bem-vindo a calculadora simples!");
            Console.Write("Pressione qualquer tecla para começar ");
            Console.ReadKey();
            Principal();

        }
        public static void Principal()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma operação:\na - adição\ns - subtração\nm - multiplicação\nd - divisão");
            Console.Write("Digite aqui sua respota: ");
            char operacao = char.Parse(Console.ReadLine());
            switch(operacao)
            {
                case 'a':
                    Operacoes.Adicao();
                    break;
                case 's':
                    Operacoes.Subtracao();
                    break;
                case 'm':
                    Operacoes.Multiplicacao();
                    break;
                case 'd':
                    Operacoes.Divisao();
                    break;
                default:
                    Console.Write("Por favor digite a letra correspondente (a/s/m/d) ");
                    Console.ReadKey();
                    Principal();
                    break;
            }
        }
        public static void TelaFinal()
        {
            Console.Clear();
            Console.Write("Obrigado por utilizar o programa! Deseja realizar outra operação? (s/n): ");
            char resposta = char.Parse(Console.ReadLine());
            if(resposta == 's')
                Principal();
            else
                Environment.Exit(0);
        }
    }
}