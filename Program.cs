using System.Security.Cryptography;

Console.Write("---Rolagem de Dado---\n");

Console.Write("Quantos lados? ");
int lados = Convert.ToInt32(Console.ReadLine());

int Rolagem = RandomNumberGenerator.GetInt32(1, lados+1);

Console.Write($"\nResultado: {Rolagem}");