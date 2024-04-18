int anonasc, idade;
Console.WriteLine("Digite o ano de seu nascimento: ");
anonasc = int.Parse(Console.ReadLine());
if (anonasc > 2024)
{
    Console.WriteLine("Ano invalido, digite um ano anterior a 2024");
}
else
{
    idade = 2024 - anonasc;
    if (idade >= 18)
    {
        Console.WriteLine($"Ja é de maior pois possui {idade} anos");
    }else
    {
        Console.WriteLine($"Ainda não é de maior pois possui {idade} anos");
            }
}