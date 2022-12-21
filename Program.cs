using System;
class Questao04
{
    static void Main()
    {
        Console.WriteLine(POV.funcaoRetornaQuantitadePOV(0.1M, 90));
        Console.WriteLine(POV.funcaoRetornaQuantitadePOV(0.1M, 100));
        Console.WriteLine(POV.funcaoRetornaQuantitadePOV(0.2M, 70));
        Console.Write("Informe o total negociado: ");
        int.TryParse(Console.ReadLine(), out int totalNegociado);
        Console.Write("Informe a porcentagem (%): ");
        decimal.TryParse(Console.ReadLine(), out decimal porcentagem);
        Console.WriteLine($"Quantidade: {POV.funcaoRetornaQuantitadePOV(porcentagem/100, totalNegociado)}");
    }
}
public static class POV
{
    public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegocidado)
    {
        return (int)(totalNegocidado*porcentagem/(1-porcentagem));
    }
}
