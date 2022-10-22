using System.Collections;
using System.Reflection.PortableExecutable;

string nombre;
decimal salario, horas, salariominimo, salarioTotal;

PedirDatos(out nombre, out salario, out horas, out salariominimo);
salarioTotal = calcularS(salario, horas);
mostarDatos(salarioTotal, nombre, salariominimo);

static void mostarDatos(decimal salarioTotal, string nombre, decimal salariominimo)
{
    Console.WriteLine("su Nombre es  : {0}" , nombre);

    if (salarioTotal > salariominimo)
    {
        Console.WriteLine("su salario es    : ${0:N2}", salarioTotal);
    }

    Console.ReadKey();
}

 static decimal calcularS(decimal salario, decimal horas)
{
   return salario * horas;
}

static void PedirDatos( out string nombre, out decimal salario, out decimal horas, out decimal salariominimo)
{
    do {
        Console.Write
            ("Digite su nombre :");
        nombre = Console.ReadLine();
    }while (nombre == "");

    do
    {

        Console.Write("Digite su salario :");
        salario = ConvertirDecimal();
    } while (salario <= 0);

    do
    {
        Console.Write("Digite sus horas trabajadas :");
        horas = ConvertirDecimal(); 
    } while (horas <= 0);

    do
    {
        Console.Write("Digite el salario minimo :");
        salariominimo = ConvertirDecimal(); 
    } while (salariominimo<= 0);
}

static decimal ConvertirDecimal()
{
    string a = Console.ReadLine();

    try
    {
        return Convert.ToDecimal(a);
    }
    catch (Exception)
    {
        return 0;
    }
}