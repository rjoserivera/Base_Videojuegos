// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hola Hoy es el día de hoy 👍");

// Declaracion de variable
int num;
num = 9;
int num2 = 23;
float estatura = 1.7f;
double peso = 70.6;
string nombre = "Edvanc";


//Operaciones aritmeticas 
/*
    + => entre o string y numero concatena
    + => entre numeros suma
    * =>
    / =>
    % => modulo para obtener el resto
    = => para asignar valor

*/
int edad = 20;
Console.WriteLine(7 % 5);
Console.WriteLine("la edad es :" +(edad + 5));
num = num + 5;
num += 5;

// ++ --
edad = 21;
Console.WriteLine("La edad es: " + edad++);
Console.WriteLine("La edad es: " + edad);
edad = 21;
Console.WriteLine("La edad es: " + ++edad);
Console.WriteLine("La edad es: " + edad);

// Operadores logicos
// >,<,>=,<=,!=,==,&&,&,||,|
num = 2;
Console.WriteLine(1 > 1 & 3 > num++);
Console.WriteLine("num = " + num);
System.Console.WriteLine("Hola Word");

// if - else if - else
double nota = 3;
if (nota >= 4)
{
    Console.WriteLine("Aprobado");
}
else if (nota >= 3)
{
    Console.WriteLine("Debe Rendir Examen");
}
else
{
    Console.WriteLine("Reprobo");
}