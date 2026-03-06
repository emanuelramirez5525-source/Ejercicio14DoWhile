// Escriba un programa que pida números al usuario hasta ingresar 0 y determine cuál fue el número mayor.

int num;
int mayor = 0;

do
{
    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());
    
    if (num !=0 && num > mayor)
    {
        mayor = num;
    }


} while (num != 0);

Console.WriteLine("El número mayor es = "+mayor);

