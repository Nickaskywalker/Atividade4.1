using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
	Console.WriteLine ("Insira a afirmação 1:");
	string pergunta1 = Console.ReadLine();
	Console.WriteLine ("Insira a afirmação 2:");
	string pergunta2 = Console.ReadLine();

	Console.WriteLine ("A frase '" + pergunta1 + "' é verdadeira?\n");
	Console.WriteLine ("Responda com 'True' ou 'False':");
	string resposta1 = Console.ReadLine();

	Console.WriteLine ("A frase '" + pergunta2 + "' é verdadeira?\n");
	Console.WriteLine ("Responda com 'True' ou 'False':");
	string resposta2 = Console.ReadLine();

	if (resposta1.Contains("True") && resposta2.Contains("True")) {
		Console.WriteLine("O resultado lógico da frase: " + pergunta1 + " e " + pergunta2 + " é: True");
	} else {
		Console.WriteLine("O resultado lógico da frase: " + pergunta1 + " e " + pergunta2 + " é: False");
	}

	if (resposta1.Contains("True") || resposta2.Contains("True")) {
		Console.WriteLine("O resultado lógico da frase: " + pergunta1 + " ou " + pergunta2 + " é: True");
	} else {
		Console.WriteLine("O resultado lógico da frase: " + pergunta1 + " ou " + pergunta2 + " é: False");
	}

	Console.Write("Press <Enter> to exit... ");
    Console.ReadKey();
  }
}