//using System.Diagnostics.CodeAnalysis;

//for (int i = 2; i <= 10; i+=2)
//{
//    Console.WriteLine(i);
//}  // Este es el primero 

//int suma = 0;
//for (int i = 1; i <= 10; i ++)
//{
//    suma += i;
//}  Console.WriteLine("la suma es:" + suma);  //Este es el segundo

//int suma = 0;
//int numero;

//Console.WriteLine("Ingrese números enteros positivos (Ingrese un número negativo para salir):");

//do
//{
//    Console.Write("Ingrese un número: ");
//    numero = int.Parse(Console.ReadLine());

//    if (numero >= 0)
//    {
//        suma += numero;
//    }
//} while (numero >= 0);
//Console.WriteLine("La suma de los números ingresados es: " + suma); // Este es el 1ro del enunciado 2

//int numero = 1;

//while (true)
//{
//    if (numero % 7 == 0 && numero % 11 == 0)
//    {
//        Console.WriteLine("El primer número entero positivo divisible entre 7 y 11 es: " + numero);
//        break;
//    }
//    numero++;
//} // Este es el 2do del 2do enunciado 

//string contraseña;
//do
//{
//    Console.Write("Ingrese la contraseña: ");
//    contraseña = Console.ReadLine();

//    if (contraseña != "jutiapa")
//    {
//        Console.WriteLine("Contraseña incorrecta. Inténtelo nuevamente.");
//    }
//} while (contraseña != "jutiapa");

//Console.WriteLine("¡Contraseña correcta! Bienvenido."); //Este es el 1ro del enunciado 3

Random rnd = new Random();
int numeroAleatorio = rnd.Next(1, 101);
int intento;

Console.WriteLine("¡Adivina el número entre 1 y 100!");

do
{
    Console.Write("Introduce tu intento: ");
    intento = int.Parse(Console.ReadLine());

    if (intento < numeroAleatorio)
    {
        Console.WriteLine("El número es mayor.");
    }
    else if (intento > numeroAleatorio)
    {
        Console.WriteLine("El número es menor.");
    }
} while (intento != numeroAleatorio);

Console.WriteLine("¡Felicidades! ¡Has adivinado el número " + numeroAleatorio + "!"); //Este es el 2do del tercer enunciado
    