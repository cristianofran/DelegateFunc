namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            DelegateUsandoParametro();

            Console.ReadKey();
        }

        private static void DelegateUsandoParametro()
        {
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();

            Func<string, string> Saudacao = BomDia;
            var saudacao = Saudacao(nome);

            Console.WriteLine(saudacao);
        }

        private static string BomDia(string nome) 
            => $"Bom dia, {nome}";
    }
}
