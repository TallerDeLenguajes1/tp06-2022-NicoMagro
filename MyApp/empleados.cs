public class empleados
{
    public string nombre{get;set;}
    public string apellido;
    public DateTime nacimiento;
    public char estadoCivil;
    public char genero;
    public DateTime ingreso;
    public double sueldoBasico;
    public cargo cargoEmpleado;

    public enum cargo{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
}