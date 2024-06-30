// See https://aka.ms/new-console-template for more information
Console.WriteLine("<-------------------------Início do Exercício----------------------------->");

Console.WriteLine("<----------------------------Exercício 1---------------------------------->");
/* 1. Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a 
      idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. */
Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();
if(string.IsNullOrWhiteSpace(nome)){
    Console.WriteLine("Nome digitado não é válido ou nulo. O programa será encerrado");
    Environment.Exit(0);
} else {
     Console.Write($"{nome}, informe sua idade em anos: ");
     string? idade_anos_digitada = Console.ReadLine();
    /* 
    O valor digitado tem que ser convertido para inteiro. A função TryParse retorna true para valor convertido e false para valor não convertido. 
    Na condição do IF, quero testar se o usuário digitou valor negativo ou se não digitou valor nenhum.
    Tive que utilizar o operador de negação para conseguir entrar no laço corretamente,
    pois se digitar um valor válido (que não seja letras ou nulo) ele convertido com sucesso e a condição de validação do TryParse será atendida, 
    retornando true, mas esse true afetará a condição de validação do IF, que espera um true para qualquer das condições testadas.
    */
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
Console.Write("Digite um valor:");
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

Console.Write($"{nome}, digite uma quantidade de dias, horas, minutos e segundos nas opções abaixo que retornar em segundos.");
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
//   b. a soma do triplo do primeiro com o terceiro.C. o terceiro elevado ao cubo.

Console.WriteLine("<----------------------------Exercício 9---------------------------------->");

Console.WriteLine("<----------------------------Exercício 10--------------------------------->");

Console.WriteLine("<--------------------------Fim do Exercício------------------------------->");

