using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoUdemyHerança.Entities
{
    class Funcionario
    {

        public List<Funcionario> Funcionarios { get;  protected set; } = new List<Funcionario>();
        public String  Nome { get; protected set; }

        public int TempoDeTrabalho { get; protected set; }

        public double ValorHora { get; protected set; }

        public Funcionario(string nome, int tempoDeTrabalho, double valorHora)
        {
            Nome = nome;
            TempoDeTrabalho = tempoDeTrabalho;
            ValorHora = valorHora;
        }

        public Funcionario()
        {
        }

        public virtual double PagamentoFuncionario()
        {

            return ValorHora* ValorHora;

        }

        public virtual void AddFuncionario(Funcionario funcionario)
        {

            Funcionarios.Add(funcionario);
            Console.WriteLine("Funcionario Cadastrado!!!");

           

        }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            foreach (var item in Funcionarios)
            {
                sb.AppendLine();
                sb.AppendLine("Nome: " + item.Nome);
                sb.AppendLine("Horas trabalhadas: " + item.TempoDeTrabalho);
                sb.AppendLine("Valor por hora: " + item.ValorHora);
                sb.AppendLine("Total: "+item.PagamentoFuncionario());
                sb.AppendLine();
            }
            return sb.ToString();

          



        }





    }
}
