using InverterString.Modelos;

InversaoDeString inverter = new();

Console.WriteLine("Digite uma string para ser invertida: ");

string inputString = Console.ReadLine()!;

string stringInvertida = inverter.InvertString(inputString);

Console.WriteLine(stringInvertida);