// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, 
//    mostrando uma mensagem de erro e voltando a pedir as informações. 

using System.Globalization;

// variável para receber o valor registrado e mostrar para o usuário no final do programa
string user, pass;

// Exercício com Do - While
Console.WriteLine("\n**************************************************");
Console.WriteLine("Vamos iniciar com um exemplo de Do - While.");

// Pedir ao usuário que entre com login
Console.Write("Digite o usuário: ");
string? user_dig = Console.ReadLine();
if (string.IsNullOrWhiteSpace(user_dig)){
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
}
user = user_dig;

Console.WriteLine("+==================================================+"); // Apenas para organização do texto
// Pedir ao usuário que entre com a senha
Console.Write("Digite a senha: ");
string? pass_dig = Console.ReadLine();
if (string.IsNullOrWhiteSpace(pass_dig)){
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
}
pass = pass_dig;

if (user == pass){
    Console.WriteLine("+==================================================+"); // Apenas para organização do texto
    do
    {
        Console.WriteLine("A senha não pode ser igual ao nome do usuário.");
        Console.WriteLine("+==================================================+"); // Apenas para organização do texto
        // Pedir ao usuário que entre com a senha novamente
        Console.Write("Digite uma senha diferente: ");
        string? pass_dig_seg = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(pass_dig_seg)){
            Console.WriteLine("Valor inválido. O programa será finalizado.");
            Environment.Exit(0);
        }
        pass = pass_dig_seg; 
    } while (pass == user);
}
Console.WriteLine("+==================================================+"); // Apenas para organização do texto
Console.WriteLine("Login realizado com sucesso!");

// Exercício com While
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Agora, vamos a outro exemplo com o While.");

// Pedir ao usuário que entre com login
Console.Write("Digite o usuário: ");
string? user_dig_ex2 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(user_dig_ex2)){
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
}
user = user_dig_ex2;

Console.WriteLine("+==================================================+"); // Apenas para organização do texto

// Pedir ao usuário que entre com a senha
Console.Write("Digita a senha: ");
string? pass_dig_ex2 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(pass_dig_ex2)){
    Console.WriteLine("O valor inválido. O programa será encerrado.");
    Environment.Exit(0);
}
pass = pass_dig_ex2;

if (user == pass){
    Console.WriteLine("+==================================================+"); // Apenas para organização do texto
    while (user == pass)
    {
       Console.WriteLine("A senha não pode ser igual ao nome do usuário."); 
       Console.WriteLine("+==================================================+"); // Apenas para organização do texto
       // Pedir ao usuário que entre com a senha novamente
        Console.Write("Digite uma senha diferente: ");
        string? pass_dig_seg_ex2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(pass_dig_seg_ex2)){
            Console.WriteLine("Valor inválido. O programa será finalizado.");
            Environment.Exit(0);
        }
        pass = pass_dig_seg_ex2;
    }
}
Console.WriteLine("+==================================================+"); // Apenas para organização do texto
Console.WriteLine("Login realizado com sucesso!");

// Exercício com For
Console.WriteLine("\n**************************************************************************************************");
Console.WriteLine("Agora, vamos a outro exemplo com o For.");

// Pedir ao usuário que entre com login
Console.Write("Digite o usuário: ");
string? user_dig_ex3 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(user_dig_ex3)){
    Console.WriteLine("Valor inválido. O programa será finalizado.");
    Environment.Exit(0);
}
user = user_dig_ex3;

Console.WriteLine("+==================================================+"); // Apenas para organização do texto

// Pedir ao usuário que entre com a senha
Console.Write("Digita a senha: ");
string? pass_dig_ex3 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(pass_dig_ex3)){
    Console.WriteLine("O valor inválido. O programa será encerrado.");
    Environment.Exit(0);
}
pass = pass_dig_ex3;

if (user == pass){
    Console.WriteLine("+==================================================+"); // Apenas para organização do texto
    for (; user == pass; )
    {
        Console.WriteLine("A senha não pode ser igual ao nome do usuário."); 
        Console.WriteLine("+==================================================+"); // Apenas para organização do texto
        // Pedir ao usuário que entre com a senha novamente
        Console.Write("Digite uma senha diferente: ");
        string? pass_dig_seg_ex3 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(pass_dig_seg_ex3)){
            Console.WriteLine("Valor inválido. O programa será finalizado.");
            Environment.Exit(0);
        }
        pass = pass_dig_seg_ex3;
    }
}
Console.WriteLine("+==================================================+"); // Apenas para organização do texto
Console.WriteLine("Login realizado com sucesso!");