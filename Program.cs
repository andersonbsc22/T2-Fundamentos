using System;

class Program
{
    static void Main()
    {
        int cantidad, aprobados = 0, desaprobados = 0;
        double nota, suma = 0, promedio, mayor = 0, menor = 0;

        Console.Write("¿Cuántas notas ingresarás?: ");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingresa la nota " + i + ": ");
            nota = double.Parse(Console.ReadLine());

            while (nota < 0 || nota > 20)
            {
                Console.Write("Nota inválida. Ingresa otra vez: ");
                nota = double.Parse(Console.ReadLine());
            }

            suma += nota;

            if (i == 1)
            {
                mayor = nota;
                menor = nota;
            }

            if (nota > mayor)
                mayor = nota;

            if (nota < menor)
                menor = nota;

            if (nota >= 12)
                aprobados++;
            else
                desaprobados++;
        }

        promedio = suma / cantidad;

        double porDesaprobados = (desaprobados * 100) / cantidad;

        Console.WriteLine("\n===== REPORTE =====");
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Nota máxima: " + mayor);
        Console.WriteLine("Nota mínima: " + menor);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Desaprobados: " + desaprobados);

        if (porDesaprobados > 75)
            Console.WriteLine("ALERTA: Más del 75% desaprobó");

        Console.ReadKey();
    }
}
//version final
