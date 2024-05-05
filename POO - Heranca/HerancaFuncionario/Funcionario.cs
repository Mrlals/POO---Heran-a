using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected float salario;

        // Construtor
        public Funcionario()
        {
        }
        public Funcionario(int codigo, string? nome, float salario)
        {

        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Codigo: {codigo} \tNome: {nome} \tSalário: R$ {salario}");
        }
        
        

    }
}