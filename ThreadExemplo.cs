using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExemple
{
class Program {
  static void Conteudo(string[] args) 
  {
    Thread thread01 = new Thread(MetodoThread);
    thread01.Start();
    Console.ReadKey();
  }      
  public static void MetodoThread()
  {
    for (int i = 0; i < 10; i++)          
    {
        Console.WriteLine("Thread sendo executado");
    }
  }
}
}