using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo;
        protected string? nome;
        protected string? endereco;

        //Construtor base para chamada nas classes filho
        public Cliente()
        {
        }
        public Cliente(int codigo, string nome, string endereco){

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
        public string? Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public virtual void MostrarDados()
        {
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tEndereço: {endereco}");
        }
    }
}