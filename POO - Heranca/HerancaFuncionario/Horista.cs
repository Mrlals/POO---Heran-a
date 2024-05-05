using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista : Funcionario
    {
        private int qtdeHorasSemana;

        public Horista()
        {
        }
        public Horista(int codigo, string? nome, float salario, int qtdeHorasSemana) : base(codigo, nome, salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
            this.qtdeHorasSemana = qtdeHorasSemana;
        }
        public int QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }
        
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Quantidade de horas da semana: {qtdeHorasSemana}");
        }
    }
}