using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Empleado
{
    // Atributos
    public string Nombre { get; set; }
    public double Sueldo { get; set; }
    public string Departamento { get; set; }

    // Constructor
    public Empleado(string nombre, double sueldo, string departamento)
    {
        Nombre = nombre;
        Sueldo = sueldo;
        Departamento = departamento;
    }

    // Método para imprimir los datos del empleado
    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}, Sueldo: {Sueldo}, Departamento: {Departamento}");
    }

    // Método para determinar si el empleado debe pagar impuestos
    public void PagarImpuestos()
    {
        if (Sueldo > 3000)
        {
            Console.WriteLine($"{Nombre} debe pagar impuestos.");
        }
        else
        {
            Console.WriteLine($"{Nombre} no debe pagar impuestos.");
        }
    }

    // Método para aumentar el sueldo del empleado
    public void AumentarSueldo(double aumento)
    {
        Sueldo += aumento;
        Console.WriteLine($"El sueldo de {Nombre} ha sido aumentado. Nuevo sueldo: {Sueldo}");
    }

    // Método para cambiar el departamento del empleado
    public void CambiarDepartamento(string nuevoDepartamento)
    {
        Departamento = nuevoDepartamento;
        Console.WriteLine($"{Nombre} ha sido transferido al departamento de {Departamento}.");
    }

    // Método para obtener el departamento del empleado
    public string ObtenerDepartamento()
    {
        return Departamento;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear objetos de la clase Empleado
        Empleado empleado1 = new Empleado("Juan", 2500, "Recursos Humanos");
        Empleado empleado2 = new Empleado("Maria", 3500, "Contabilidad");
        Empleado empleado3 = new Empleado("Pedro", 2800, "Ventas");

        // Imprimir datos de los empleados
        Console.WriteLine("Datos del empleado 1:");
        empleado1.ImprimirDatos();
        empleado1.PagarImpuestos();
        empleado1.AumentarSueldo(500);
        empleado1.CambiarDepartamento("Administración");
        Console.WriteLine();

        Console.WriteLine("Datos del empleado 2:");
        empleado2.ImprimirDatos();
        empleado2.PagarImpuestos();
        empleado2.AumentarSueldo(200);
        empleado2.CambiarDepartamento("Finanzas");
        Console.WriteLine();

        Console.WriteLine("Datos del empleado 3:");
        empleado3.ImprimirDatos();
        empleado3.PagarImpuestos();
        empleado3.AumentarSueldo(300);
        empleado3.CambiarDepartamento("Marketing");
        Console.WriteLine();

        Console.ReadKey();
    }
}
