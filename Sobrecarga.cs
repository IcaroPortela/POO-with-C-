using System;
namespace Sobrecarga
{
    public class Animal2
    {
        public int idade { get; set;}
        public int tamanho { get; set;}

        public Animal2(){
            this.idade = 1;
            this.tamanho = 1;
        }
        public Animal2(int idade){
            this.idade = idade;
            this.tamanho = 1;
        }
        public virtual void FazerSom(){}
        public virtual void FazerSom(int altura){
        }
    }
    public class Cão : Animal2{
        public override void FazerSom()
        {
            base.FazerSom();
            Console.WriteLine("Latindo alto");
            Console.WriteLine(150 + "Hz");
        }
    }
}