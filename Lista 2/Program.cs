// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.WriteLine("<-------------------------Início do Exercício----------------------------->");

Console.WriteLine("<----------------------------Exercício 1---------------------------------->");
// 1. Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a 
//    idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();
if(string.IsNullOrWhiteSpace(nome)){
    Console.WriteLine("Nome digitado não é válido ou nulo. O programa será encerrado");
    Environment.Exit(0);
} else {
     Console.Write($"{nome}, informe sua idade em anos: ");
     string? idade_anos_digitada = Console.ReadLine();
    // O valor digitado tem que ser convertido para inteiro. A função TryParse retorna true para valor convertido e false para valor não convertido. 
    // Na condição do IF, quero testar se o usuário digitou valor negativo ou se não digitou valor nenhum.
    // Tive que utilizar o operador de negação para conseguir entrar no laço corretamente,
    // pois se digitar um valor válido (que não seja letras ou nulo) ele convertido com sucesso e a condição de validação do TryParse será atendida, 
    // retornando true, mas esse true afetará a condição de validação do IF, que espera um true para qualquer das condições testadas.
    if(!int.TryParse(idade_anos_digitada, out int idade_anos) || idade_anos < 0){
        Console.WriteLine("A idade digitada não é válida para continuação do programa. A execução será finalizada.");
        Environment.Exit(0);
    }
    Console.Write($"{nome}, informe a quantidade de meses posteriores a sua idade completa em anos (Exemplo: 10 anos e 7 meses, digite apenas 7): ");
    string? idade_meses_digitada = Console.ReadLine();
    if(!int.TryParse(idade_meses_digitada, out int idade_meses) || idade_meses < 0 || idade_meses > 11){
        Console.WriteLine("A idade digitada não é válida para continuação do programa. A execução será finalizada.");
        Environment.Exit(0);
    }
    Console.Write($"{nome}, informe a quantidade de dias posteriores a sua idade completa em anos (Exemplo: 10 anos, 7 meses e 20 dias, digite apenas 20): ");
    string? idade_dias_digitada = Console.ReadLine();
    if(!int.TryParse(idade_dias_digitada, out int idade_dias) || idade_dias < 0 || idade_dias > 30){
        Console.WriteLine("A idade digitada não é válida para continuação do programa. A execução será finalizada.");
        Environment.Exit(0);
    }
    int idade_em_dias = (idade_anos * 365) + (idade_meses * 30) + idade_dias;
    Console.WriteLine($"Sua idade em dias é: {idade_em_dias}");
} 

Console.WriteLine("<----------------------------Exercício 2---------------------------------->");
// 2. Faça um Programa que peça 4 notas e mostre a média (10 + 10 + 10 + 10 / 4 tem que dar resultado 10).
Console.WriteLine($"{nome}, agora você poderá digitar 4 notas e retornaremos sua nota média.");
Console.Write("Digite a primeira nota: ");
string? nota1_digitada = Console.ReadLine();
if (!double.TryParse(nota1_digitada, out double nota1) || nota1 < 0 || nota1 > 10){
    Console.WriteLine("O valor digitado é inválido. O programa será encerrado.");
    Environment.Exit(0);
}
Console.Write("Digite a segunda nota: ");
string? nota2_digitada = Console.ReadLine();
if (!double.TryParse(nota2_digitada, out double nota2) || nota2 < 0 || nota2 > 10){
    Console.WriteLine("O valor digitado é inválido. O programa será encerrado.");
    Environment.Exit(0);
}
Console.Write("Digite a terceira nota: ");
string? nota3_digitada = Console.ReadLine();
if (!double.TryParse(nota3_digitada, out double nota3) || nota3 < 0 || nota3 > 10){
    Console.WriteLine("O valor digitado é inválido. O programa será encerrado.");
    Environment.Exit(0);
}
Console.Write("Digite a quarta nota: ");
string? nota4_digitada = Console.ReadLine();
if (!double.TryParse(nota4_digitada, out double nota4) || nota4 < 0 || nota4 > 10){
    Console.WriteLine("O valor digitado é inválido. O programa será encerrado.");
    Environment.Exit(0);
}
Console.WriteLine($"A média da sua nota é: {(nota1+nota2+nota3+nota4)/4}");

Console.WriteLine("<----------------------------Exercício 3---------------------------------->");
//3. Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.
Console.WriteLine($"{nome}, digite o valor da base ou da altura de um quadrado e retornaremos a área e o dobro da área dele. ");
Console.Write("Digite um valor: ");
string? valor_digitado = Console.ReadLine();
if (!double.TryParse(valor_digitado, out double valor) || valor <= 0){
    Console.WriteLine("O valor digitado é inválido. O programa será encerrado.");
    Environment.Exit(0);
}
double area_quadrado = valor * valor;
Console.WriteLine($"A área do quadrado é {area_quadrado}");
Console.WriteLine($"O dobro da área do quadrado é {area_quadrado * 2}");

Console.WriteLine("<----------------------------Exercício 4---------------------------------->");
// 4. Escreva um programa que leia a quantidade de dias, horas, minutos e segundos do usuário. 
//  Calcule o total em segundos. (1 minutos tem quantos segundos? 1 hora tem quantos minutos?)

Console.WriteLine($"{nome}, digite uma quantidade de dias, horas, minutos e segundos nas opções abaixo que retornaremos o total em segundos.");
Console.Write("Digite uma quantidade de dias: ");
string? dias_digitado = Console.ReadLine();
if(!int.TryParse(dias_digitado, out int dias) || dias < 0){
    Console.WriteLine("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Digite uma quantidade de horas: ");
string? horas_digitada = Console.ReadLine();
if (!int.TryParse(horas_digitada, out int horas) || horas <= 0){
    Console.WriteLine("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Digite uma quantidade de minutos: ");
string? minutos_digitado = Console.ReadLine();
if (!int.TryParse(minutos_digitado, out int minutos) || minutos < 0){
    Console.WriteLine("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Digite uma quantidade de segundos: ");
string? segundos_digitado = Console.ReadLine();
if (!int.TryParse(segundos_digitado, out int segundos) || segundos < 0){
    Console.WriteLine("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
int total_segundos = (dias * 24 * 60 * 60) + (horas * 60 * 60) + (minutos * 60) + segundos;
Console.WriteLine($"O total de segundos, considerando todos os valores digitados, é: {total_segundos}");

Console.WriteLine("<----------------------------Exercício 5---------------------------------->");
//5. Calcule o tempo de uma viagem de carro. Pergunte a distância a percorrer e a velocidade média esperada para a viagem.
Console.WriteLine($"{nome}, vamos calcular a quantidade de horas de uma viagem baseada no KM e velocidade");
Console.Write("Digite a distância: ");
string? distancia_digitada = Console.ReadLine();
if (!double.TryParse(distancia_digitada, out double distancia) || distancia <= 0){
    Console.WriteLine("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Digite a velocidade média: ");
string? velocidade_digitada = Console.ReadLine();
if (!double.TryParse(velocidade_digitada, out double velocidade) || velocidade <= 0){
    Console.WriteLine("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.WriteLine($"O tempo estimado para viagem é de {distancia / velocidade} horas.");

Console.WriteLine("<----------------------------Exercício 6---------------------------------->");
// 6.	Escreva um programa para calcular a redução do tempo de vida de um fumante. Pergunte a quantidade 
//      de cigarros fumados por dia e quantos anos ele já fumou. Considere que um fumante perde 10 minutos de vida a cada cigarro,
//      calcule quantos dias de vida um fumante perderá. Exiba o total de dias.

Console.WriteLine($"{nome}, você é fumante? Digite 'S' para sim ou 'N' para não");
string? resposta = Console.ReadLine();
if (resposta == "S" || resposta == "s"){
    Console.Write("Há quanto anos você fuma? ");
    string? tempo = Console.ReadLine();
    if (!int.TryParse(tempo, out int anos) || anos <= 0){
        Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
        Environment.Exit(0);
    }
    Console.WriteLine("Quantos cigarros você fuma por dia? ");
    string? quantidade = Console.ReadLine();
    if (!int.TryParse(quantidade, out int qtde) || qtde <= 0){
        Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
        Environment.Exit(0);
    }
    int perda_dia = qtde * 10;
    int perda_minutos = anos * 365 * perda_dia;
    double perda_total = perda_minutos / 60 / 24;
    Console.WriteLine($" Você perdeu {perda_total} dias da sua vida.");
} else if (resposta == "N" || resposta == "n"){
    Console.WriteLine("Parabéns! você não está perdendo dias de vida.");
} else {
    Console.WriteLine("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}

Console.WriteLine("<----------------------------Exercício 7---------------------------------->");
//7. Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. 
//   Calcule e mostre o total do seu salário no referido mês.
Console.WriteLine($"{nome}, informe abaixo quanto você ganha por hora e quantas horas trabalha por mês, que retornaremos o valor do seu salário");
Console.Write("Quanto você ganha por hora: ");
string? valor_hora_digitado = Console.ReadLine();
if (!double.TryParse(valor_hora_digitado, out double valor_hora) || valor_hora <= 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Quantas horas você trabalha por mês: ");
string? qtde_hora_digitado = Console.ReadLine();
if (!int.TryParse(qtde_hora_digitado, out int horas_trabalhadas) || horas_trabalhadas <= 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
double salario = valor_hora * horas_trabalhadas;
Console.WriteLine($"O valor do seu salário é: {salario}");

Console.WriteLine("<----------------------------Exercício 8---------------------------------->");
//8. Faça um Programa que peça 2 números inteiros (int) e um número real (double). Calcule e mostre:
//   a. o produto do dobro do primeiro com metade do segundo.
//   b. a soma do triplo do primeiro com o terceiro.
//   C. o terceiro elevado ao cubo.
Console.Write($"{nome}, digite um número inteiro: ");
// Tentei usar a conversão abaixo, para ficar mais simples, mas não funcionou bem
//int num1 = int.Parse(Console.ReadLine() ?? "0");
string? num1 = Console.ReadLine();
if (!double.TryParse(num1, out double numero1) || numero1 <= 0){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Digite mais um número inteiro: ");
//int num2 = int.Parse(Console.ReadLine() ?? "0");
string? num2 = Console.ReadLine();
if (!double.TryParse(num2, out double numero2) || numero2 <= 0){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Agora, digite um número real: ");
//double num3 = double.Parse(Console.ReadLine() ?? "0");
string? num3 = Console.ReadLine();
if (!double.TryParse(num3, out double numero3) || numero3 <= 0){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
// Não consegui descobrir porque o cálculo abaixo está retornando zero quando o valor digitado é = 1. Tive que alterar o tipo de todos para double 
// double a = numero1 * 2 * (numero2 / 2);
// Console.WriteLine(a);
Console.WriteLine($"O dobro do primeiro número x a metade do segundo equivale a: {numero1 * 2 * (numero2 / 2)}");
Console.WriteLine($"O triplo do primeiro número somado com o terceiro equivale a: {numero1 * 3 + numero3}");
Console.WriteLine($"O terceiro número elevado ao cubo equivale a: {Math.Pow(numero3, 3)}");

Console.WriteLine("<----------------------------Exercício 9---------------------------------->");
//9. Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, 
// usando a seguinte fórmula: (72,7 * altura) – 58
    Console.Write($"{nome}, digite sua altura: ");
    string? altura = Console.ReadLine();
    if (double.TryParse(altura, NumberStyles.Float, CultureInfo.InvariantCulture, out double alt)){
        double peso_ideal = (72.7 * alt) - 58;
        Console.WriteLine($"Seu peso ideal é: {peso_ideal:F2} KG");
    } else {
        Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
        Environment.Exit(0);
    }


Console.WriteLine("<----------------------------Exercício 10--------------------------------->");
// 10. Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
//     a. salário bruto.
//     b. quanto pagou ao INSS.
//     c. quanto pagou ao sindicato.
//     d. o salário líquido.
//     e. calcule os descontos e o salário líquido, conforme a tabela abaixo:
//      MOSTRAR NA TELA O RESUMO DO PAGAMENTO ABAIXO:
//      + Salário Bruto        : R$
//      - IR (11%)                : R$
//      - INSS (8%)             : R$
//      - Sindicato ( 5%)      : R$
//      = Salário Liquido      : R$
//      Obs.: Salário Bruto - Descontos = Salário Líquido.
Console.WriteLine($"{nome}, informe abaixo quanto você ganha por hora e quantas horas trabalha por mês, que retornaremos o valor do seu salário bruto, descontos e seu salário líquido");
Console.Write("Quanto você ganha por hora: ");
string? valor_hora_informado = Console.ReadLine();
if (!double.TryParse(valor_hora_informado, out double vlr_hora) || vlr_hora <= 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Quantas horas você trabalha por mês: ");
string? quant_hora_digitado = Console.ReadLine();
if (!int.TryParse(quant_hora_digitado, out int horas_trabalho) || horas_trabalho <= 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
double salario_bruto = vlr_hora * horas_trabalho;
double ir = salario_bruto * 0.11;
double inss = salario_bruto * 0.08;
double sindicato = salario_bruto * 0.05;
double sal_liquido = salario_bruto - ir - inss - sindicato;
Console.WriteLine($"+ Salário Bruto        : R$ {salario_bruto}");
Console.WriteLine($"- IR (11%)             : R$ {ir}");
Console.WriteLine($"- INSS (8%)            : R$ {inss}");
Console.WriteLine($"- Sindicato ( 5%)      : R$ {sindicato}");
Console.WriteLine($"= Salário Liquido      : R$ {sal_liquido}");

Console.WriteLine("<----------------------------Exercício 11--------------------------------->");
//11. Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos brancos, 
//    nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total de eleitores. 
Console.WriteLine($"{nome}, informe abaixo quantos eleitores há no seu município, votos brancos, nulos e validos que retornaremos os percentuais.");
Console.Write("Quantidade de eleitores: ");
string? num_eleitores = Console.ReadLine();
if (!double.TryParse(num_eleitores, out double eleitores) || eleitores <= 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Votos em branco: ");
string? votos_brancos = Console.ReadLine();
if (!double.TryParse(votos_brancos, out double em_branco) || em_branco < 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Votos nulos: ");
string? votos_nulos = Console.ReadLine();
if (!double.TryParse(votos_nulos, out double nulos) || nulos < 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
Console.Write("Votos válidos: ");
string? votos_validos = Console.ReadLine();
if (!double.TryParse(votos_validos, out double validos) || validos < 0 ){
    Console.Write("O valor digitado não é válido para continuação do programa. A execução será finalizada.");
    Environment.Exit(0);
}
double percentual_branco = em_branco / eleitores * 100;
double percentual_nulos = nulos / eleitores * 100;
double percentual_validos = validos / eleitores * 100;
Console.WriteLine($"Total de eleitores: {eleitores}");
Console.WriteLine($"Percentual de votos em branco: {percentual_branco}%");
Console.WriteLine($"Percentual de votos nulos: {percentual_nulos}%");
Console.WriteLine($"Percentual de votos válidos: {percentual_validos}%");

// Observação: Não consegui utilizar as variáveis digitadas pelo usuário no formato int e depois utilizar numa variável double que 
// receberia o cálculo da porcentagem. O resultado ficava zerado. Só depois que alterei todas as variáveis para double que passou a 
// funcionar. Lembro de que poderíamos fazer conversão implicita de inteiro para double, não o contrário. É isso mesmo? Será uma questão
// do DotNet 8?

Console.WriteLine("<----------------------------Exercício 12--------------------------------->");
//12. Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês e mais 5% do valor das vendas por ele efetuadas. 
//    Escrever um algoritmo que leia o número de carros por ele vendidos, o valor do carro e o salário fixo.         
//    Calcule e escreva o salário final do vendedor.

Console.WriteLine("<----------------------------Exercício 13--------------------------------->");
//13. Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno. 
//    Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. 
//    Fórmula para o cálculo da média é: média final = (N1 * 2 + N2 * 3 + N3 * 5) / 10


Console.WriteLine("<--------------------------Fim do Exercício------------------------------->");
