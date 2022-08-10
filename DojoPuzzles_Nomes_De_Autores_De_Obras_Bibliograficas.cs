using System;
using System.Text.RegularExpressions;

Console.WriteLine("-> Nomes de Autores de Obras Bibliográficas");
Console.WriteLine("----------------------------------------");
Console.WriteLine("-> Qual o nome do autor: ");
    string primeiro_autor_nome = Console.ReadLine(); 
Console.WriteLine("-> Qual o Sobrenome do autor: ");
    string primeiro_autor_sobrenome = Console.ReadLine(); 
Console.WriteLine($"-> Seu autor se chama: {primeiro_autor_nome} {primeiro_autor_sobrenome}");
Console.WriteLine("----------------------------------------");
Console.WriteLine("-> Qual o nome do autor: ");
    string segundo_autor_nome = Console.ReadLine();
Console.WriteLine("-> Qual o sobrenome do autor: ");
    string segundo_autor_sobrenome = Console.ReadLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine($"-> Seu autor se chama: {segundo_autor_nome} {segundo_autor_sobrenome}");

var quantidade_Autores = 0;
for (int i = 0; i < 2; i++)
{
    i = quantidade_Autores;
    Console.WriteLine(i);
}

primeiro_autor_sobrenome = primeiro_autor_sobrenome.Replace("das", "");
primeiro_autor_sobrenome = primeiro_autor_sobrenome.Replace("de", "");
primeiro_autor_sobrenome = primeiro_autor_sobrenome.Replace("dos", "");
primeiro_autor_sobrenome = primeiro_autor_sobrenome.Replace("da", "");
primeiro_autor_sobrenome = primeiro_autor_sobrenome.Replace("do", "");
//Ao colocar de forma contratia a sequencia obtive sucesso para ocultar as palavras desejadas deixando o plural antes do singula. Ex("dos" antes  - "do" depois).
segundo_autor_sobrenome = segundo_autor_sobrenome.Replace("das",""); 
segundo_autor_sobrenome = segundo_autor_sobrenome.Replace("de", "");  
segundo_autor_sobrenome = segundo_autor_sobrenome.Replace("dos","");
segundo_autor_sobrenome = segundo_autor_sobrenome.Replace("da", "");
segundo_autor_sobrenome = segundo_autor_sobrenome.Replace("do", "");

    string upper_nome_autor_1;
    string upper_nome_autor_2;
    string sobrenome_1;
    string sobrenome_2;

upper_nome_autor_1 = char.ToUpper(primeiro_autor_nome[0]) + primeiro_autor_nome.Substring(1);
upper_nome_autor_2 = char.ToUpper(segundo_autor_nome[0]) + segundo_autor_nome.Substring(1);

sobrenome_1 = primeiro_autor_sobrenome.ToUpper();
sobrenome_2 = segundo_autor_sobrenome.ToUpper();

Console.WriteLine($"{sobrenome_1/*.Remove(0, 3)*/}, {upper_nome_autor_1}");
Console.WriteLine($"{sobrenome_2/*.Remove(0, 3)*/}, {upper_nome_autor_2}");



