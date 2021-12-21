using System;
using System.Collections.Generic;
namespace Agregando
{
    public class Frutas
    {
        public string Frutas1 { get; set; }
        public int Qtd { get;set; }

        public Frutas(string Frutas1, int Qtd)
        {
           this.Frutas1 = Frutas1;
           this.Qtd = Qtd; 
        }
    }
}