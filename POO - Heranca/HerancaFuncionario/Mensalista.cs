using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        private int qtdeHorasTrabalhadas;

        public Mensalista()
        {
        }
        public Mensalista(int codigo, string? nome, float salario, int qtdeHorasTrabalhadas) : base(codigo, nome, salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
            this.qtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }

        public int QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
        
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Quantidade de horas trabalhadas: {qtdeHorasTrabalhadas}");
        }
    }
}