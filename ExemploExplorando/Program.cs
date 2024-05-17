using System.Globalization;
using ExemploExplorando.models;

string dataString = "2023-12-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if(sucesso) {
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
} else {
    Console.WriteLine($"{dataString} não é uma data válida");
}




















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C8"));

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 12052027;
// Console.WriteLine(numero.ToString("##-##-####"));
















// int numero1 = 10;
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);


























// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome:"Buta");

// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();












// Pessoa p1 = new Pessoa();

// p1.Nome = "Leonardo";
// p1.Sobrenome = "Buta";
// p1.Idade = 5;
// p1.Apresentar();
