using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpregados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            while (cont > 0)
            {
                double salarioliq1 = 0;
                double salarioliq2 = 0;
                double salarioliq3 = 0;
                Console.WriteLine("Insira a forma de contratação usando (A)ssalariado, (C)missionado, (H)orista: ");
                string forma = Console.ReadLine();

                switch (forma)
                {
                    case "A":
                        Console.WriteLine("Insira o salário: ");
                        double sal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o desconto: ");
                        double desc = double.Parse(Console.ReadLine());
                        salarioliq1 = sal - desc;
                        break;

                    case "C":
                        Console.WriteLine("Insira a quantidade de peças: ");
                        int qtdpcs = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o valor pago por cada peça: ");
                        double valor = double.Parse(Console.ReadLine());
                        salarioliq2 = qtdpcs * valor;
                        break;

                    case "H":
                        Console.WriteLine("Insira a quantidade de horas trabalhadas: ");
                        double hrs = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o valor da hora: ");
                        double valorhr = double.Parse(Console.ReadLine());
                        salarioliq3 = valorhr * hrs;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;

                }
                
                    double folhadepagamento = double.Parse(Console.ReadLine());
                Console.WriteLine("");


            }
        }
    }
}
