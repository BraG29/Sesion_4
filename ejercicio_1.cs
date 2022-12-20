/*Escribe una tabla de multiplicar del 1 al 10 
para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10*/

namespace ejercicio_1
{
    public class Ejercicio1
    {
        public static void ejercicio1(int numero)
        {
            Console.WriteLine("Multiplicacion de 1 a 10 de: " + numero);  
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero*i);
            }
        }
    }
}
