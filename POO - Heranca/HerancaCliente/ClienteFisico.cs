using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteFisico : Cliente
    {
        private int rg;

        //Criação do Construtor para chamada na Main:
        public ClienteFisico() // Construtor padrão
        {

        }
        // Construtor com parâmetros
        public ClienteFisico(int codigo, string nome, string endereco, int rg) : base(codigo, nome, endereco)
        {
            // adicionando a referencia dos parametros passados pelo construtor (utilizando o "this")
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.rg = rg;
        }

        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"\tRG: {rg}");
        }
    }
}