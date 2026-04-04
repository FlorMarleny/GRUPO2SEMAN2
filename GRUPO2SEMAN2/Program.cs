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