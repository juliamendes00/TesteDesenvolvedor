using System.Security.Cryptography;

double[] estados = new double[5] { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
string[] siglas = new string[5] {"SP", "RJ", "MG", "ES", "OUTROS"};
double valor, fatura ;

valor = estados.Sum();
Console.WriteLine("Valor mensal da distribuidora: {0}" , valor.ToString("N3"));

for (int i = 0; i < 5; i++)
{
    Console.Write(siglas[i] + " = ");
    fatura = (estados[i] / valor) / 100;
    Console.WriteLine(fatura.ToString("N4") + "%");

}
