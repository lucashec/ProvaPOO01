using System;

namespace ProvaPOO01
{
    class Escola
    {
        private string anoLetivo;
        private decimal anuidade;

        public Escola(string anoLetivo, decimal anuidade)
        {
            this.anoLetivo = anoLetivo;
            this.anuidade = anuidade;
        }
        public void SetAnoLetivo(string anoLetivo){
            this.anoLetivo = anoLetivo;
        }
        public void SetAnuidade(decimal anuidade) {
            this.anuidade = anuidade;
        }
        public decimal GetValorMensal()
        {
            return anuidade / 12;
        }
        public decimal GetValorComDesconto()
        {
            return anuidade * 90 / 100;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Escola x = new Escola("1º ano", 12000);
            Console.WriteLine("Hello World!");
        }
    }
}
