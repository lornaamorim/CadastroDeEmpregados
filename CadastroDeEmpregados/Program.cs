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

            {
                int cont = 0;
                int continuar = 1;
                double salarioliq = 0;


                while (continuar == 1)
                {
                    Console.WriteLine("Insira a forma de contratação usando (A)ssalariado (C)omissionado (H)orista: ");
                    string contratacao = Console.ReadLine();

                    switch (contratacao)
                    {
                        case "A":
                            Console.WriteLine("Insira o valor do salário bruto: ");
                            double salb = double.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o valor do desconto: ");
                            double desc = double.Parse(Console.ReadLine());

                            salarioliq = salb - desc;
                            break;

                        case "C":
                            Console.WriteLine("Insira a quantidade de peças produzidas: ");
                            int qntdpecas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o valor pago por peça: ");
                            double valor = double.Parse(Console.ReadLine());

                            salarioliq = qntdpecas * valor;
                            break;

                        case "H":
                            Console.WriteLine("Insira a quantidade de horas trabalhadas: ");
                            int hora = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o valor recebido por hora: ");
                            double valorhora = double.Parse(Console.ReadLine());

                            salarioliq = hora * valorhora;
                            break;
                    }

                    Console.WriteLine("Deseja continuar? (1)Sim (2)Não: ");
                    continuar = int.Parse(Console.ReadLine());
                    cont++;
                    salarioliq++;
                }

                     double folhapagamento = salarioliq + salarioliq;
                     double mediasalarial = folhapagamento / cont;

                Console.WriteLine("Folha de pagamento R$: " + folhapagamento);
                Console.WriteLine("Funcionários cadastrados: " + cont);
                Console.WriteLine("Média salarial R$: " + mediasalarial);

                Console.ReadKey();

            }
        }
    }
}
