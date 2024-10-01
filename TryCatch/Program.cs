//Exemplo de trycatch com numerador e denominador//
//O bloco try-catch em c# permite que vc execute um bloco de codigo
//(try)que pode gerar exeções.Se uma exceção,ela irá ser tratada no bloco catch//

/* exemplo 1 com valores*/
//try
//{
//    Console.Write("digite o nomerador"); // string "5" == 5;//
//    int numerador = int.Parse(Console.ReadLine());

//    Console.Write("digite o denominador");
//    int denominador = int.Parse(Console.ReadLine());

//    int divisãoResu = numerador / denominador;
//    Console.WriteLine($"O resultado da divisão é de {divisãoResu}");

//}
//catch(DivideByZeroException)
//{
//    Console.WriteLine("ERRO!NÃO É POSSIVEL DIVIDIR POR ZERO");
//}
//catch(FormatException)
//{
//    Console.WriteLine("Digite numeros validos");
//}
//Console.ReadKey();




//exemplo2 com casas decimais ultilizando Double e convertendo esses valores com o TryParse//
using System.Globalization;

try
{
    Console.Write("digite o nomerador:");
    double numerador;
    //significa diferente//
    while(!double.TryParse(Console.ReadLine(),NumberStyles.Any, CultureInfo.InvariantCulture, out numerador))
    {
        Console.WriteLine("ERRO! porfavor digite um numero valido");
        Console.Write("digite um numerador:");
    }

    Console.Write("digite o denominador:");
    double denominador;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
    {
        Console.WriteLine("ERRO! porfavor digite um numero valido");
        Console.Write("digite um denominador:");
    }

    //verifica o valor do denominador e caso seja 0 gera uma exceção//
    if (denominador == 0)
    {
        throw new DivideByZeroException();
    }

    double divisãoResu = numerador / denominador;
    Console.WriteLine($"O resultado da divisão é de {divisãoResu}");

}
catch (DivideByZeroException)
{
    Console.WriteLine("ERRO!NÃO É POSSIVEL DIVIDIR POR ZERO");
}
catch (FormatException)
{
    Console.WriteLine("Digite numeros validos");
}
Console.ReadKey();