int saldo = 1000;
int monto;
string continuar = " ";

do
{
    Console.WriteLine("Ingrese el monto a retirar:");
    if (!int.TryParse(Console.ReadLine(), out monto))
    {
        Console.WriteLine("Ingrese un número válido");
        continue;
    }

    if (monto > 0)
    {
        if (monto % 20 == 0)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
                Console.WriteLine("Retiro exitoso");
                Console.WriteLine("Saldo actual: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        else
        {
            Console.WriteLine("Error de monto");
        }
    }
    else
    {
        Console.WriteLine("Ingresar monto correcto positivo");
    }

    Console.WriteLine("¿Desea continuar? (si/no)");
    continuar = Console.ReadLine().ToLower();

} while (continuar != "no");

Console.WriteLine("Gracias por usar el cajero");