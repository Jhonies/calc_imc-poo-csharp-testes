using System;

namespace IMC;

public class CalculoIMC
{
    public static double Calcular(double peso, double altura)
    {
        if (peso <= 0)
            throw new ArgumentException("Peso inválido!");

        if (altura <= 0)
            throw new ArgumentException("Altura inválida!");

        return peso / (altura * altura);
    }
}
