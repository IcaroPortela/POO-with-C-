using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        public Animal()
        {
            this.Especie = "";
            this.Peso = 0;
        }
        public Animal(string especie, Double peso)
        {
            this.Especie = especie;
            this.Peso = peso;
        }

        public string Especie { get; set;}
        public double Peso { get; set;}
    }
    public class AnimalPlus: Animal
    {
        public AnimalPlus():base()
        {
            this.TipoAlimentacao = "";
        }
        public AnimalPlus(string especie, double peso, string tipoAlimentacao): base(especie, peso)
        {
            this.TipoAlimentacao = tipoAlimentacao;
        }
        public string TipoAlimentacao { get; set; }
        public void ExibirDados()
        {
            Console.WriteLine("Especie: " + this.Especie);
            Console.WriteLine("Peso: " + this.Peso);
            Console.WriteLine("Tipo de Alimentação: " + this.TipoAlimentacao);
        }

    }
}