//Saida de texto
Console.WriteLine("Hello Word!");

string nome;
int idade;
decimal altura;

Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();
Console.Write("Quantos anos você tem? ");
idade = int.Parse(Console.ReadLine());
Console.Write("Qual a sua altura? ");
altura = decimal.Parse(Console.ReadLine());

Console.WriteLine("Prazer " + nome + " sua idade é " + idade + " Sua altura é : " + altura);