// main()
using HerancaFuncionario;

// ---- Base ---- 
Funcionario f = new Funcionario();
f.Codigo = 1000;
f.Nome = "Barosvildo Pratowski";
f.Salario = 2230;
f.Mostrar();

// Usando Construtor:
Funcionario f2 = new Funcionario(2000,"Azarilda Azure", 2800);
f2.Mostrar();


// ---- Filho herança Mensalista ----
Mensalista m = new Mensalista();
m.Codigo = 3000;
m.Nome = "Brazuska Bravilina";
m.Salario = 3325;
m.QtdeHorasTrabalhadas = 150;
m.Mostrar();

//usando Construtor:
Mensalista m2 = new Mensalista(4000, "Ariluína mendonça", 3800, 170);
m2.Mostrar();


// ---- Filho herança Horista ----
Horista h = new Horista();
h.Codigo = 5000;
h.Nome = "Brutalis Brutão";
h.Salario  = 5280;
h.QtdeHorasSemana = 40;
h.Mostrar();

//usando Construtor:
Horista h2 = new Horista(6000, "Birutas Lokuraz", 4200, 44);
h2.Mostrar();