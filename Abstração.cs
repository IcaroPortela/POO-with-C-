using System;
namespace Abstração
{
    public abstract class Animal
    {
        public abstract void EmitirSons();
        public void Dormir(){
            Console.WriteLine("ZZZ...");
        }
    }
    public class Preguica: Animal
    {
        public override void EmitirSons(){
            Console.WriteLine("Roncar.");
        }
    }
}