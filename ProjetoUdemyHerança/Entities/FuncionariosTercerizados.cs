using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoUdemyHerança.Entities
{
    class FuncionariosTercerizados : Funcionario
    {

        public double DespesaAdicional { get; set; }

        public FuncionariosTercerizados()
        {
        }

        public FuncionariosTercerizados(string nome, int tempoDeTrabalho, double valor, double despesaAdicional) : base(nome,tempoDeTrabalho,valor)
        {
            DespesaAdicional = despesaAdicional;
        }


        public override double PagamentoFuncionario()
        {
            return base.PagamentoFuncionario() + DespesaAdicional * 1.10;
        }

        public override void AddFuncionario(Funcionario funcionario)
        {
            base.AddFuncionario(funcionario);
        }







    }
}
