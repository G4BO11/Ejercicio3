using System;

namespace Ejercicio3
{
    class Program
    {        
        static void Main(string[] args)
        {
            ProcedimientoHemoglobina.procedimiento();
            ProcedimientoHemoglobina.impresionResultados();
        }        
    }

    class ProcedimientoHemoglobina
    {
        static int num;
        static int contadorHombres = 0;
        static int contadorMujeres = 0;
        //variables locas 
        static int alerta1M = 0, alerta2M = 0, sinAlerta1M = 0, alerta1F = 0, alerta2F = 0, sinAlerta1F = 0;
        public static void procedimiento()
        {
            Console.Write("Cuantos pacientes va a ingresar?: ");
            num = int.Parse(Console.ReadLine());
            for (int j = 0; j < num; j++)
            {
                Console.Write("Ingrese su nivel de hemogloblina: ");
                float hemo = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su genero teniendo en cuenta que '1' es Masculino y '2' es Femenino");
                Console.Write("Ingrese su genero: ");
                int genero = int.Parse(Console.ReadLine());
                while (genero != 1 && genero != 2)
                {
                    Console.WriteLine("ERRROR. INGRESO MAL EL NUMERO INTENTE NUEVAMENTE");
                    Console.WriteLine("Ingrese su genero teniendo en cuenta que '1' es Masculino y '2' es Femenino");
                    Console.Write("Ingrese su genero: ");
                    genero = int.Parse(Console.ReadLine());
                }
                switch (genero)
                {
                    case 1:
                        if (hemo < 11.6) { alerta1M += 1; }
                        else if (hemo > 11.6 && hemo < 15) { sinAlerta1M += 1; }
                        else if (hemo > 15) { alerta2M += 1; }
                        contadorHombres += 1;
                        break;
                    case 2:
                        if (hemo < 13.2) { alerta1F += 1; }
                        else if (hemo > 13.2 && hemo < 16.6) { sinAlerta1F += 1; }
                        else if (hemo > 16.6) { alerta2F += 1; }
                        contadorMujeres += 1;
                        break;
                    default:
                        Console.WriteLine("Escribio mal la opcion. Intente nuevamente");
                        break;
                }
            }
        }
        public static void impresionResultados()
        {
            Console.WriteLine("\n\n\t\t--------RESULTADOS FINALES----------");
            Console.WriteLine($"\t\t Cuantos hombres hay?: {contadorHombres}");
            Console.WriteLine($"\t\t Cuantos Mujeres hay?: {contadorMujeres}");
            Console.WriteLine("\t\t HOMBRES:");
            Console.WriteLine($"\t\t Con alerta tipo 1: {alerta1M}");
            Console.WriteLine($"\t\t Con alerta tipo 2: {alerta2M}");
            Console.WriteLine($"\t\t Sin alerta: {sinAlerta1M}");
            Console.WriteLine("\t\t MUJERES:");
            Console.WriteLine($"\t\t Con alerta tipo 1: {alerta1F}");
            Console.WriteLine($"\t\t Con alerta tipo 2: {alerta2F}");
            Console.WriteLine($"\t\t Sin alerta: {sinAlerta1F}");
            Console.WriteLine("\t\t------------------------------------");
        }
    }
}
