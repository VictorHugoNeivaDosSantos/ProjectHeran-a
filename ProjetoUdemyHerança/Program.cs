using System;
using ProjetoUdemyHerança.Entities;

namespace ProjetoUdemyHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fn = new Funcionario();
       

           Console.Write("Quantos Funcionarios: ");
            int qtdF = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdF; i++)
            {
                Console.WriteLine("################ " + i + " ################");
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas trabalhadas: ");
                int hour = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valor = double.Parse(Console.ReadLine());

                Console.Write("1.Normal  2.Tercerizado: ");
                int tipoFun = int.Parse(Console.ReadLine());

                if (tipoFun == 1)
                {
                    Funcionario fn2 = new Funcionario(nome, hour, valor);

                    fn.AddFuncionario(fn2);

                    Console.WriteLine();


                }
                else if (tipoFun == 2)
                {
                    Console.Write("Qual a despesa adicional: ");
                    double despesaAdc = double.Parse(Console.ReadLine());
                    Funcionario fn2 = new FuncionariosTercerizados(nome, hour,valor, despesaAdc);

                    fn.AddFuncionario(fn2);

                    Console.WriteLine();


                }

            }


            Console.WriteLine(fn);




        }
    }
}
