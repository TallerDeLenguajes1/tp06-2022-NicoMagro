calculadora calc = new calculadora(0);
int bucle = 1;
int opcion = 0;
while (bucle == 1)
{
    double valor = 0;
    Console.WriteLine("Presione 1 para sumar, 2 para restar, 3 para multiplicar, 4 para dividir, 5 para resetear el resultado o 6 para salir de la calculadora");
    opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
    {
        Console.WriteLine("Ingrese un numero: ");
        valor = Convert.ToDouble(Console.ReadLine());
    }

    switch (opcion)
    {
        case 1:
            calc.suma(valor);
            break;
        case 2:
            calc.resta(valor);
            break;
        case 3:
            calc.multiplicar(valor);
            break;
        case 4:
            calc.dividir(valor);
            break;
        case 5:
            calc.limpiar();
            break;
        case 6:
            bucle = 0;
            break;

        default:
            break;
    };

    Console.WriteLine("Resultado = {0}", calc.resultado);
}

Console.WriteLine("Gracias por usar la calculadora!! :)");