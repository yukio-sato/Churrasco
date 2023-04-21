int qtdAdultos,adultoQBebe,AdultoN, criancas;
void frase(string frase)

{
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(75);
}
}
void calculadora(double quantiAdulto, double quantiaCrianca, string produto, string tipo)
{
    double calculo =0;
if (produto != "Cerveja" && produto != "Refrigerante")
{
calculo = quantiAdulto*qtdAdultos + quantiaCrianca*criancas;
}
else if (produto == "Cerveja" && produto != "Refrigerante")
{
calculo = quantiAdulto*adultoQBebe; 
}
else if (produto != "Cerveja" && produto == "Refrigerante")
{
calculo = quantiAdulto*AdultoN + quantiaCrianca*criancas; 
}
Console.ForegroundColor = ConsoleColor.White;
if (tipo == "kg")
{
if (calculo/1000 >= 1)
{
frase($"{produto}: {calculo/1000}kg\n");
}
else
{
frase($"{produto}: {calculo}g\n");
}
}
else if (tipo == "l")
{
if (calculo/1000 >= 1)
{
frase($"{produto}: {calculo/1000}l\n");
}
else
{
frase($"{produto}: {calculo}ml\n");
} 
}

}
Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
frase("Digite quantidade de adultos que consomem bebidas com alcool: ");

Console.ForegroundColor = ConsoleColor.White;

adultoQBebe = int.Parse(Console.ReadLine()!);
Console.ForegroundColor = ConsoleColor.Yellow;
frase("Digite quantidade de adultos que NÃO consomem bebidas com alcool: ");

Console.ForegroundColor = ConsoleColor.White;

AdultoN = int.Parse(Console.ReadLine()!);
qtdAdultos = adultoQBebe + AdultoN;
Console.ForegroundColor = ConsoleColor.Yellow;
frase("Digite quantidade de crianças: ");

Console.ForegroundColor = ConsoleColor.White;
criancas = int.Parse(Console.ReadLine()!);
// ****************************************************
// *****                  STEAK                   *****
// ****************************************************
calculadora(400,200,"Carne","kg");
// ****************************************************
// *****             Acompanhamentos              *****
// ****************************************************
calculadora(200,200,"Acompanhamentos","kg");
// ****************************************************
// *****                  BEER                    *****
// ****************************************************
calculadora(2000,0,"Cerveja","l");
// ****************************************************
// *****                  Refri                   *****
// ****************************************************
calculadora(500,500,"Refrigerante","l");
// ****************************************************
// *****                  Water                   *****
// ****************************************************
calculadora(400,400,"Água","l");
Console.ResetColor();