// 3. Faça um programa que leia e valide as seguintes informações: 
//      A Nome: tem que ser maior que 3 caracteres; (comando Length)
//      B Idade: entre 0 e 150; 
//      C Salário: maior que zero; 
//      D Sexo: 'f' ou 'm'; 
//      E Estado Civil: 's', 'c', 'v', ‘d';
//      Se o usuário digitar um valor fora do que foi pedido, mostrar um erro e pedir para digitar novamente.
 
Console.WriteLine("\n***************************************************************");
string nome;
// Pedir ao usuário que entre com o nome
Console.Write("Digite seu nome: ");
string? nome_dig = Console.ReadLine();
if (string.IsNullOrWhiteSpace(nome_dig)){
    Console.WriteLine("Nome inválido. O programa será finalizado.");
    Environment.Exit(0);
} 
nome = nome_dig;
int tam_nome = nome_dig.Length;
if (tam_nome <= 3){
    while(tam_nome <= 3){
        Console.Write("O nome deve ter mais de três letras: digite o seu nome: ");
        string? nome_dig_seg = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome_dig_seg)){
            Console.WriteLine("Nome inválido. O programa será finalizado.");
            Environment.Exit(0);
        } 
        int tam_nome_seg = nome_dig_seg.Length;
        tam_nome = tam_nome_seg;
    }
}
Console.WriteLine("+===============================================================+"); // Apenas para organização do texto
// Pedir ao usuário que entre com a idade
Console.Write("Digite sua idade: ");
string? idade_dig = Console.ReadLine();
if (!int.TryParse(idade_dig, out int idade)){
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
} 
// idade deve ser entre 0 e 150 (de 1 até 149)
while(idade <= 0 || idade >= 150)
{
    Console.Write("A idade deve ser maior que zero e menor que 150. Digite a idade novamente: ");
    string? idadeDigSeg = Console.ReadLine();
    if (!int.TryParse(idadeDigSeg, out int idadeSeg)){
        Console.WriteLine("Valor inválido. O programa será finalizado.");
        Environment.Exit(0);
    } 
    idade = idadeSeg;
}

Console.WriteLine("+===============================================================+"); // Apenas para organização do texto
// Pedir ao usuário que entre com O salário
Console.Write("Digite seu salário: ");
string? salDig = Console.ReadLine();
if (!float.TryParse(salDig, out float salario)){
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
} 
// salario deve ser maior que zero
while(salario <= 0)
{
    Console.Write("O salário deve ser maior que zero. Digite a idade novamente: ");
    string? salDigSeg = Console.ReadLine();
    if (!float.TryParse(salDigSeg, out float salSeg)){
        Console.WriteLine("Valor inválido. O programa será finalizado.");
        Environment.Exit(0);
    } 
    salario = salSeg;
}

Console.WriteLine("+===============================================================+"); // Apenas para organização do texto
// Pedir ao usuário que entre com o sexo
char sexo = '\0';
Console.Write("Digite seu sexo: ");
string? sexoDig = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(sexoDig) && char.TryParse(sexoDig, out char sexoCon)){
    sexo = char.ToUpper(sexoCon);
} else {
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
}

// Sexo deve ser m ou f
while(sexo != 'F' && sexo != 'M')
{
    Console.WriteLine("O sexo dever ser M para masculino ou F para feminino. Digite a idade novamente: ");
    Console.Write("Digite o sexo novamente: ");
    string? sexoDigSeg = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(sexoDigSeg)&& char.TryParse(sexoDigSeg, out char sexoConSeg)){
        sexo = sexoConSeg;
    } 
}
Console.WriteLine("+===============================================================+"); // Apenas para organização do texto
// Pedir ao usuário que entre com o estado civil
char estCivil = '\0';
Console.Write("Digite seu estado civil (S = Solteiro, C = Casado, V = Viúvo, D = Divorciado): ");
string? estCivilDig = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(estCivilDig) && char.TryParse(estCivilDig, out char estCivilCon)){
    estCivil = char.ToUpper(estCivilCon);
} else {
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
}

// Sexo deve ser m ou f
while(estCivil != 'S' && estCivil != 'C' && estCivil != 'V' && estCivil != 'D')
{
    Console.WriteLine("O estado civil dever ser S = Solteiro, C = Casado, V = Viúvo, D = Divorciado.");
    Console.Write("Digite o estado civil novamente: ");
    string? estCivilDigSeg = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(estCivilDigSeg)&& char.TryParse(estCivilDigSeg, out char estCivilDigSegCon)){
        sexo = char.ToUpper(estCivilDigSegCon);
    } 
}
Console.WriteLine ($"Cadastro finalizado com sucesso.\nNome: {nome} \nIdade: {idade} \nSalário: {salario} \nSexo: {sexo} \nEstado civil {estCivil}");