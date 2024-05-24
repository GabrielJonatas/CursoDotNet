using DesafioDeCodigoAvanadeII.Models;

string senha = Console.ReadLine().Trim();

string resultado = PasswordStrength.VerificarForcaSenha(senha);

Console.WriteLine(resultado);





















// string atributo = Console.ReadLine();

// int valorMinimo = int.Parse(Console.ReadLine());

// int valorMaximo = int.Parse(Console.ReadLine());

// int valorAtributo = int.Parse(Console.ReadLine());

// if (AttributesGuardian.VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo))
// {
//     Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
// }
// else
// {
//     Console.WriteLine("O valor do atributo está fora do intervalo especificado");
// }






// int ataque = int.Parse(Console.ReadLine());

// int defesa = int.Parse(Console.ReadLine());

// int danoCausado = DamageCounter.Counter(ataque, defesa);
// Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);