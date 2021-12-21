using System;

namespace Matemática
{
    public class Calculo
    {
        public int X;
        public int Y;
        public int Resultado;    
        void Somador() {}
    }
    public class somar : Calculo{
        public void Somador(){
            Resultado = X + Y;
        }
    }
}