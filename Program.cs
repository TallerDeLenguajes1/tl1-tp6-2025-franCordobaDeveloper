/*
    Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
    texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
    número sólo si éste es mayor a 0.
*/

// int num;
// int numAInvertir = 0;
// bool control = false;

// string? numString;

// while (!control)
// {
//     Console.WriteLine("Ingrese un numero para invertir");
//     numString = Console.ReadLine();
//     control = int.TryParse(numString, out num);

//     if (!control)
//     {
//         Console.WriteLine("El valor ingresado es incorrecto: " + numString);
//     }
//     else
//     {
//         if (num > 0)
//         {
//             numAInvertir = 0;
//             while (num > 0)
//             {
//                 numAInvertir = (numAInvertir * 10) + (num % 10);
//                 num /= 10;
//             }
//             Console.WriteLine("El numero invertido : " + numAInvertir);
//             break;
//         }
//         else
//         {
//             Console.WriteLine("El numero que ingreso es 0 un negativo");
//         }
//     }


// }


/*

    Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo

*/


int opc;

int num1 = 0, num2 = 0, resultado = 0;

string numString;

bool continuar = true;

// calculadoraV2
double num3 = 0;
double resultado2;


while (continuar)
{
    do
    {

        Console.WriteLine("\n Seleccione una opcion \n");
        Console.WriteLine("1) Sumar 2 numeros \n");
        Console.WriteLine("2) Restar 2 numeros \n");
        Console.WriteLine("3) Multiplicar 2 numeros \n");
        Console.WriteLine("4) Dividir 2 numeros \n");
        Console.WriteLine("5) Valor Absoluto de un numero \n");
        Console.WriteLine("6) Cuadrado de un numero \n");
        Console.WriteLine("7) La raiz cudrada de un numero \n");
        Console.WriteLine("8) Seno de un numero \n");
        Console.WriteLine("9) Coseno Absoluto de un numero \n");
        Console.WriteLine("10)  La parte entera de un numero \n");
        Console.WriteLine("11) Maximo entre 2 numeros \n");
        Console.WriteLine("12) Minimo entre 2 numeros \n");
        Console.WriteLine("0) Salir de app de consola \n");

        numString = Console.ReadLine();
    } while (!int.TryParse(numString, out opc) || opc < 0 || opc > 12); ;

    if (opc == 0)
    {
        Console.WriteLine("Selecciono 0 esta saliendo de la app de consola.");
        continuar = false;
    }


    bool control1 = true, control2 = true, control3 = true;

    if ((opc > 0 && opc <= 4) || (opc >= 11 && opc <= 12))
    {
        Console.WriteLine("Ingrese un numero: \n");
        numString = Console.ReadLine();
        control1 = int.TryParse(numString, out num1);

        Console.WriteLine("Ingrese un numero: \n");
        numString = Console.ReadLine();
        control2 = int.TryParse(numString, out num2);
    }

    if (opc >= 5 && opc <= 10)
    {
        Console.WriteLine("Ingrese un numero: \n");
        numString = Console.ReadLine();
        control3 = double.TryParse(numString, out num3);
    }

    if (!control1 && !control2)
    {
        Console.WriteLine("Ingreso un valor erroneo");
        Console.WriteLine("Desea Realizar otra Operacion? - Presione 0 para salir o 1 para relizar otra operacion");
        numString = Console.ReadLine();
        continuar = int.TryParse(numString, out opc);
        if (opc == 0)
        {
            continuar = false;
        }
        Console.Clear();
    }

    switch (opc)
    {
        case 1:
            Console.WriteLine("1) Sumar 2 numeros \n");
            resultado = num1 + num2;
            Console.WriteLine("Resultado : " + resultado);
            break;
        case 2:
            Console.WriteLine("2) Restar 2 numeros \n");
            resultado = num1 - num2;
            Console.WriteLine("Resultado : " + resultado);
            break;
        case 3:
            Console.WriteLine("3) Multiplicar 2 numeros \n");
            resultado = num1 * num2;
            Console.WriteLine("Resultado : " + resultado);
            break;

        case 4:
            Console.WriteLine("4) Dividir 2 numeros \n");
            resultado = num1 / num2;
            Console.WriteLine("Resultado : " + resultado);
            break;
        case 5:
            Console.WriteLine("5)El valor absoluto de un numero: ");
            resultado2 = Math.Abs(num3);
            Console.WriteLine("Resultado: " + resultado2);
            break;

        case 6:
            Console.WriteLine("6) Cuadrado de un numero;");
            resultado2 = Math.Pow(num3, 2);
            Console.WriteLine("Resultado: " + resultado2);

            break;

        case 7:
            Console.WriteLine("7)Raiz Cuadrada de un numero");
            resultado2 = Math.Sqrt(num3);
            Console.WriteLine("Resultado: " + resultado2);
            break;

        case 8:
            Console.WriteLine("Seno de un numero: ");
            resultado2 = Math.Sin(num3);
            Console.WriteLine("Resultado: " + resultado2);
            break;

        case 9:
            Console.WriteLine("Coseno de un numero: ");
            resultado2 = Math.Cos(num3);
            Console.WriteLine("Resultado: " + resultado2);
            break;

        case 10:
            Console.WriteLine("Parte entera de un numero");
            int parteEntera = (int)Math.Floor(num3);
            Console.WriteLine("Resultado: " + parteEntera);
            break;

        case 11:
            Console.WriteLine("Eligio la opcion numero '11' de El Maximo entre 2 numeros");
            resultado = Math.Max(num1, num2);
            Console.WriteLine("El maximo entre " + num1 + " y " + num2 + " es: " + resultado);
            break;
        case 12:
            Console.WriteLine("Eligio la opcion numero '12' de El Minimo entre 2 numeros");
            resultado = Math.Min(num1, num2);
            Console.WriteLine("El minimo entre " + num1 + " y " + num2 + " es: " + resultado);
            break;

        case 0:
            Console.WriteLine("Saliendo...");
            continuar = false;
            break;
    }


    Console.WriteLine("Desea Realizar otra Operacion? - Presione 0 para salir o 1 para relizar otra operacion");
    numString = Console.ReadLine();
    continuar = int.TryParse(numString, out opc);
    if (opc == 0)
    {
        continuar = false;
    }
    Console.Clear();
}

