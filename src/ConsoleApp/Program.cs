namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            DelegateUsandoParametro();
            DelegateUsandoDoisParametros();
            Console.ReadKey();
        }

        #region [DelegateUsandoDoisParametros]

        private static void DelegateUsandoDoisParametros()
        {
            Console.Write("Digite a primeira parcela: ");
            var parcela1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda parcela: ");
            var parcela2 = Convert.ToDouble(Console.ReadLine());

            Func<double, double, double> Calculadora = Somar;
            var soma = Calculadora(parcela1, parcela2);

            Console.WriteLine("{0} + {1} = {2}", parcela1, parcela2, soma);
        }

        private static double Somar(double parcela1, double parcela2)
            => parcela1 + parcela2;

        #endregion

        #region [DelegateUsandoParametro]

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

        #endregion
    }
}
