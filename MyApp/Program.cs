using System.Globalization;

Console.WriteLine("Ingrese la cantidad de empleados a cargar: ");
int cantidad = Convert.ToInt32(Console.ReadLine());
empleados[] emp = new empleados[cantidad];

CultureInfo provider = CultureInfo.InvariantCulture;
string format = "MM/dd/yyyy";

for (int i = 0; i < cantidad; i++)
{
    emp[i] = new empleados();
    Console.WriteLine("A continuacion ingrese los datos del empleado");
    Console.WriteLine("Nombre: ");
    emp[i].nombre = Console.ReadLine();
    Console.WriteLine("Apellido: ");
    emp[i].apellido = Console.ReadLine();
    Console.WriteLine("Nacimiento: ");
    emp[i].nacimiento = DateTime.ParseExact(Console.ReadLine(), format, provider);
    Console.WriteLine("Estado civil ('C' casado, 'S' soltero): ");
    emp[i].estadoCivil = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Genero: ");
    emp[i].genero = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Fecha de ingreso: ");
    emp[i].ingreso = DateTime.ParseExact(Console.ReadLine(), format, provider);
    Console.WriteLine("Sueldo basico: ");
    emp[i].sueldoBasico = Convert.ToDouble(Console.ReadLine());

    Random rnd = new Random();
    int opcion = rnd.Next(1,5);

    switch (opcion)
    {
        case 1:
            emp[i].cargoEmpleado = cargo.Administrativo;
            Console.WriteLine("Rango: Administrativo");
            break;
        case 2:
            emp[i].cargoEmpleado = cargo.Auxiliar;
            Console.WriteLine("Rango: Auxiliar");
            break;
        case 3:
            emp[i].cargoEmpleado = cargo.Especialista;
            Console.WriteLine("Rango: Especialista");
            break;
        case 4:
            emp[i].cargoEmpleado = cargo.Ingeniero;
            Console.WriteLine("Rango: Ingeniero");
            break;
        case 5:
            emp[i].cargoEmpleado = cargo.Investigador;
            Console.WriteLine("Rango: Investigador");
            break;
        default:
        break;
    }
}