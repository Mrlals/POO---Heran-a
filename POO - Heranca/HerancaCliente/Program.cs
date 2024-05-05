//Main ()
using HerancaCliente;

//instanciando um cliente e apresentando os dados base
Cliente c = new Cliente();
c.Codigo = 100;
c.Nome = "Astrobagnaldo Astral";
c.Endereco = "Rua sem asfalto nº 0";
c.MostrarDados();

// instanciando um cliente fisico e apresentando os dados
ClienteFisico cf = new ClienteFisico();
cf.Codigo = 200;
cf.Nome = "Manolo Véio";
cf.Endereco = "Rua sem saída nº infinito";
cf.Rg = 1234567890;
// Ao mostrar os dados so cliente será carregado tanto os dados da classe base quanto o Rg da classe filho
cf.MostrarDados();

//passando os parametros direto na instanciação do Construtor: (Obs: o construtor deve ser referenciado na classe)
ClienteFisico cf2 = new ClienteFisico(300,"José João Julio Jiróca", "Rua Esburacada Nº da placa quebrada", 1112223334);
cf2.MostrarDados();

//mesma situação se emulação do caso do ClienteFisico
ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 400;
cj.Nome = "Prinisquila da Silva";
cj.Endereco = "Rua inominável sem númeo";
cj.Cnpj = 1234567890;
cj.MostrarDados();