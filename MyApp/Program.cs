Console.WriteLine("A continuacion ingrese los datos del empleado");
Console.WriteLine("Nombre: ");
empleados empleado = new empleados();
empleado.nombre = Console.ReadLine();
empleado.apellido = Console.ReadLine();
empleado.nacimiento = DateTime.UtcNow;
empleado.estadoCivil = Convert.ToChar(Console.ReadLine());
empleado.genero = Convert.ToChar(Console.ReadLine());
empleado.ingreso = DateTime.Now;
empleado.sueldoBasico = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Elija el cargo del empleado");
int opcion = Convert.ToInt32(Console.ReadLine());
switch (opcion)
{
    case 1:
        empleado.cargoEmpleado = empleados.cargo.Administrativo;
        break;
    case 2:
        empleado.cargoEmpleado = empleados.cargo.Auxiliar;
        break;
    case 3:
        empleado.cargoEmpleado = empleados.cargo.Especialista;
        break;
    case 4:
        empleado.cargoEmpleado = empleados.cargo.Ingeniero;
        break;
    case 5:
        empleado.cargoEmpleado = empleados.cargo.Investigador;
        break;
    default:
    break;
}