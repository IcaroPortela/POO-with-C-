using System; //esta biblioteca serve para usar os comandos do sistema;
using System.IO; // esta biblioteca serve para converter os comandos em liguagem de maquina;
using System.Threading.Tasks; // No final iremos estudar sobre esta biblioteca;
using System.Collections.Generic; // permite criar listas 
//using Matemática; // iremos chamar a classe que está em outro arquivo assim poderemo instanciar o objeto
//using Caixa;
//using Composição;
using Abstração;
using Sobrecarga;
using Zoo;

namespace Programa
{
    public class Program{
        //static List<Frutas> frutas;
        //static List<Grupo> grupos;
        //static List<NotaFiscal> notas;
        public static void Main(string[] args)
        {         
            //instanciando um objeto
            /*somar som1 = new somar();
            som1.X = 50;
            som1.Y = 10;
            som1.Somador(); 
            */

            //Criando uma lista;
           /* frutas = new List<Frutas>();
            frutas.Add(new Frutas("Maçã",20));
            frutas.Add(new Frutas("Uva",30));
            frutas.Add(new Frutas("Abacaxi", 40));
            frutas.Add(new Frutas("Goiaba", 50));
            frutas.Add(new Frutas("Jaca", 32));

            foreach (Frutas f in frutas)
            {
                Console.WriteLine(f.Frutas1 + " " + f.Qtd);
            } 
            */

            //Usando Agregações 
            /*CartaoCredito cdc = new CartaoCredito();
            Cliente cl = new Cliente();
            cl.Nome = "Robson da Silva";
        
            cdc.Numero = "5564 - 4589 - 4236 - 7895";
            cdc.DatadeValidade = "15/12/2026";
            cdc.cliente = cl;
        
            Console.WriteLine("Cliente: " + cl.Nome);
            Console.WriteLine("Numero do cartão de crédito: " + cdc.Numero);
            Console.WriteLine("Data de Vencimento: " + cdc.DatadeValidade);
            Console.WriteLine("O cliente se chama: " + cdc.cliente.Nome);
            */
            //Usando Composição
            /*notas = new List<NotaFiscal>();
            notas.Add(new NotaFiscal("Bola de futebol","16/04/2021", 1));
            notas.Add(new NotaFiscal("Camisa da Seleção Brasileira","16/04/2021", 2));
            notas.Add(new NotaFiscal("Raquetes de Frescoball","16/04/2021", 1));
            Console.WriteLine("Essas foram suas compras no dia: ");
            foreach (NotaFiscal nt in notas){
                Console.WriteLine("Produto: " + nt.NProdutos + " " + nt.Datadacompra + " "+ nt.Qtd);
            }*/
            /*
            //Abstração
            Preguica ani = new Preguica();
            ani.Dormir();
            ani.EmitirSons();

            //Sobrecarga
            Cão Canis = new Cão();
            Canis.idade = 1;
            Canis.tamanho = 30;
            Console.WriteLine("Aruki tem: " + Canis.idade + " anos e seu tamanho é de " + Canis.tamanho +"cm.");
            Canis.FazerSom();
            while (Canis.idade < 10)
            {
                Canis.idade ++;
                Canis.tamanho += 10;
                Console.WriteLine("Seu cão está mais velho! " + Canis.idade + " anos e tem " + Canis.tamanho + "cm");    
            } */

            //Gerenciando um Zoo
            List<AnimalPlus> animais = new List<AnimalPlus>();
            int countCar = 0, countHer = 0;
            Console.WriteLine("Quantos são carnivoros e quantos são herbivoros: ");
            for (int i = 0; i < 4; i++)
            {
                AnimalPlus animal = new AnimalPlus();
                Console.Write("Especie: ");
                animal.Especie = Console.ReadLine();
                Console.Write("Peso: ");
                animal.Peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Tipo de alimentação: ");
                animal.TipoAlimentacao = Console.ReadLine();
                if (animal.TipoAlimentacao == "carnivoro")
                {
                    //Carnivoro
                    countCar++;
                }
                else
                {
                    //Herbivoro
                    countHer++;
                }
                animais.Add(animal);
            }
            Console.WriteLine("Total de animais carnivoros: "+countCar);
            Console.WriteLine("Total de animais herbivoros: "+countHer);
            Console.ReadKey();
        }
    }
}
