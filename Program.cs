double PrecoEtanol, PrecoGasolina, Porcentagem;


Console.WriteLine("--- Etanol ou Gasolina? ---");


Console.Write("Digite o preço do etanol (R$)...: ");


PrecoEtanol = Convert.ToDouble(Console.ReadLine()!);



Console.Write($"Digite o preço da gasolina (R$)...: ");


PrecoGasolina = Convert.ToDouble(Console.ReadLine()!);


Porcentagem = (PrecoEtanol/PrecoGasolina)*100;

Console.WriteLine ($"O preço do etanol corresponde a {Porcentagem:N1}% do preço da gasolina.");

/*        -OUTRA FORMA DE RESOLUÇÃO-
string Recomendação;
if (Porcentagem>73)

{
    Recomendação = "Gasolina";
}


else if (Porcentagem<73)

{

    Recomendação = "Álcool";

}

Console.WriteLine($"Recomendação: Abasteça com {Recomendação}.");*/

string Recomendação;
if (Porcentagem>73)
{
    Recomendação = "Gasolina";
    Console.WriteLine($"Recomendação: Abasteça com {Recomendação}.");
}

else if (Porcentagem<73)
{
Recomendação = "Álcool";
    Console.WriteLine($"Recomendação: Abasteça com {Recomendação}.");

}
 