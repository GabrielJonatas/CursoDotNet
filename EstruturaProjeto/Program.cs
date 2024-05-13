using EstruturaProjeto.Models;

// forma diferente de declarar array
/*
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
*/

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// int contadorForEach = 0;
// foreach ( string item in listaString) 
// {
//     Console.WriteLine($"Posição N° {contadorForEach} - {item}");
//     contadorForEach++;
// }


// // forma nova de declarar um array abaixo
// int[] arrayInteiros = [72, 64, 50];

// int[] arrayInteirosDobrado =  new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// // arrayInteiros[3];
// for (int contador = 0; contador<arrayInteiros.Length; contador++) 
// {
//     Console.WriteLine($"Posição n° {contador} - {arrayInteiros[contador]}");
// }

// // percorrendo array com o FOREACH
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// } 

/*
string opcao;
bool exibirMenu = true;

while(exibirMenu) 
{
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            // Enviroment.Exit(0);
            break;
        
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}*/

/*
do {
    comandos...
} while (condição de parada);

*/


/* 

while (condicao de parada) 
{
    Comandos ....
}

break;


*/


/* 
for (condicao inicial; condicao de parada; mudanca) 
{
    comando 1
    comando 2
    .....
}


*/ 



// Calculadora calculadora = new Calculadora();

// int x = Console.Read();
// int y = Console.Read();

// calculadora.Somar(9 , 3);
// calculadora.Subtrair(9 , 3);
// calculadora.Multiplicar(9 , 3);
// calculadora.Dividir(9 , 3);
// calculadora.Potencia(9 , 2);
// calculadora.Seno(30);
// calculadora.Cosseno(30);
// calculadora.Tangente(30);
// calculadora.RaizQuadrada(16);

// NOT (!)
// AND (&&)
// OR (Pipe, ||)


// Console.ReadLine();

/* 
    switch(variavel) 
    {
        case condicao:
            .....
            break

        default:
            ....
            break;
    }


*/


/* 
if (condição) {
    comando 1
} if else () {
    comando 2
}
*/


/* 
if (condição) {
    comando 1
} else {
    comando 2
}
*/

//string a = "15";

// int b = 0;

//int.TryParse(a, out int b);

//Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// double a = 4 / (2 + 2);

// Console.WriteLine(a);


// int a = 5;
// double b = a; // casting implicito, onde int é transformado para double

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();
// converte para string é so utilizar ToString(), pois esta presente em todos os tipos

// Console.WriteLine(a);

// int a = Convert.ToInt32(null); // cast - Casting de valor string para int
// int a = int.Parse(null); // Equivalente ao casting para inteiro

// Convert tem tratamento para null values, é preferivel utiliza-lo para casting

// Console.WriteLine(a);

// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5; // c = c + 5;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura);
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Buta";
// pessoa1.Idade = 26;

// pessoa1.Apresentar();