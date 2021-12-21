using System;
namespace Composição
{
    public class Produto {}
    public class NotaFiscal
    {
        public string Datadacompra { get; set; }
        public string NProdutos { get; set;}
        public int Qtd { get; set; }
        /*public void Imprimir()
        {
            Console.WriteLine("Obrigado e volte sempre!");
        }*/
        public NotaFiscal(string NProdutos, string Datadacompra, int Qtd)
        {
            this.NProdutos = NProdutos;
            this.Datadacompra = Datadacompra;
            this.Qtd = Qtd;
        }
        public Produto produtos { get; set;}
    }
}