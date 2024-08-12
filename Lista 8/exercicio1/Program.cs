// Iniciando o programa

using exercicio1;
using System;

Console.WriteLine("==============================================================================");

// Solicitar as medidas do local
Console.Write("Digite a base do local em metros: ");
double baseLocal = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura do local em metros: ");
double alturaLocal = Convert.ToDouble(Console.ReadLine());

// Criar um objeto Retangulo com as medidas fornecidas
Retangulo local = new Retangulo(baseLocal, alturaLocal);

// Calcular a área e o perímetro do local
double areaLocal = local.CalcularArea();
double perimetroLocal = local.CalcularPerimetro();

// Solicitar as medidas do piso
Console.Write("Digite a área de um piso em metros quadrados: ");
double areaPiso = Convert.ToDouble(Console.ReadLine());

// Calcular a quantidade de pisos
double quantidadePisos = Math.Ceiling(areaLocal / areaPiso);

// Calcular a quantidade de rodapés
Console.Write("Digite o comprimento de uma peça de rodapé em metros: ");
double comprimentoRodape = Convert.ToDouble(Console.ReadLine());

double quantidadeRodape = Math.Ceiling(perimetroLocal / comprimentoRodape);

// Exibe os resultados
Console.WriteLine("\nAbaixo, segue informações sobre a área do local e a quantidade de pisos e rodapés necessários:");
Console.WriteLine("Área do local: " + areaLocal + " metros quadrados");
Console.WriteLine("Perímetro do local: " + perimetroLocal + " metros");
Console.WriteLine("Quantidade de pisos necessários: " + quantidadePisos);
Console.WriteLine("Quantidade de rodapés necessários: " + quantidadeRodape);