using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public int Cnpj{
            get { return cnpj; }
            set { cnpj = value; }
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"\tCNPJ: {cnpj}");
        }

    }
}