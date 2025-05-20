double height, pesoIdeal;
string sexo;

Console.Write("Digite sua height em m..........: ");
height = Convert.ToDouble(Console.ReadLine());

Console.Write("Sexo [M]an / [W]oman...: ");
sexo = Console.ReadLine()!.ToUpper().Trim();

if (sexo != "M" && sexo != "W")
{
    Console.WriteLine("Não possuo fórmula para cálculo.");
}
else
{
    if (sexo == "M")
    {
        pesoIdeal = height * 72.7 - 58.0;
    }
    else
    {
        pesoIdeal = height * 62.1 - 44.7;
    }

    Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}kg.");
}
