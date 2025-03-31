// See https://aka.ms/new-console-template for more information

string  nome, sobrenome;
Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine()!;
Console.WriteLine("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!;
Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");
Console.WriteLine($"Seu nome de catalogo é: {sobrenome.ToUpper()}, {nome.ToLower()}");
