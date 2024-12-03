public class Actividad2
{
    const int ValorMax = 100;
    const int ValorMin = 15;
    const int IntentosMax = 5;

    public static void Main()
    {
        Console.WriteLine("Introduce la cantidad de números que quieres en la lista:");
        int valores = Convert.ToInt32(Console.ReadLine());

        if (valores <= 0)
        {
            Console.WriteLine("El número de valores debe ser mayor que 0.");
            return;
        }
        int vidas = 0;
        while (vidas < IntentosMax)
        {
            Intentos(valores);
            vidas++;
        }
    }

    public static void Intentos(int valores)
    {
        int intentos = 0;
        int cantidadValida = 0;
        long producto = 1;
        string final = "";

        while (cantidadValida < valores)
        {
            Console.WriteLine($"Introduce un número (entre {ValorMin} y {ValorMax}):");
            int num = Convert.ToInt32(Console.ReadLine());
            intentos++;

            if (num >= ValorMin && num <= ValorMax)
            {
                cantidadValida++;
                final = num + " " + final;
                producto *= num;

            }
            else
            {
                Console.WriteLine($"El número {num} está fuera del rango permitido.");
            }
        }

        if (cantidadValida == valores)
        {
            Console.WriteLine($"Sus numeros son {final} ");
            Console.WriteLine($"El producto de los números válidos es: {producto}");
        }
        else
        {
            Console.WriteLine("No se introdujeron suficientes valores válidos dentro del límite de intentos.");
        }
    }
}

