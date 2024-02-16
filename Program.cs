using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Ingrese los datos del empleado:");

            // Ingreso de datos
            Console.Write("Número de cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            int tipoEmpleado = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de horas laboradas: ");
            double horasLaboradas = double.Parse(Console.ReadLine());

            Console.Write("Precio por hora: ");
            double precioPorHora = double.Parse(Console.ReadLine());

            // Cálculo del salario ordinario
            double salarioOrdinario = horasLaboradas * precioPorHora;

            // Cálculo del aumento
            double aumento = 0.0;
            switch (tipoEmpleado)
            {
                case 1:
                    aumento = salarioOrdinario * 0.15;
                    break;
                case 2:
                    aumento = salarioOrdinario * 0.10;
                    break;
                case 3:
                    aumento = salarioOrdinario * 0.05;
                    break;
                default:
                    Console.WriteLine("Tipo de empleado no válido.");
                    return;
            }

            // Cálculo del salario bruto
            double salarioBruto = salarioOrdinario + aumento;

            // Cálculo de deducciones por CCSS
            double deduccionCCSS = salarioBruto * 0.0917;

            // Cálculo del salario neto
            double salarioNeto = salarioBruto - deduccionCCSS;

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Cedula: {cedula}");
            Console.WriteLine($"Nombre Empleado: {nombre}");
            Console.WriteLine($"Tipo Empleado: {tipoEmpleado}");
            Console.WriteLine($"Salario por Hora: {precioPorHora:C}");
            Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
            Console.WriteLine($"Salario Ordinario: {salarioOrdinario:C}");
            Console.WriteLine($"Aumento: {aumento:C}");
            Console.WriteLine($"Salario Bruto: {salarioBruto:C}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS:C}");
            Console.WriteLine($"Salario Neto: {salarioNeto:C}");

            // Preguntar al usuario si desea realizar otro cálculo
            Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
                break;
        }
    }
}
