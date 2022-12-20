/*Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
Tienes completa libertad para elegir el formato de la salida.*/

namespace ejercicio_2
{
    public class Ejercicio2
    {
        public static void ejercicio2(int numero)
        {
            if(numero == 0)
            {
                Console.WriteLine("El número es 0");
                return;
            }
            //No esta muy claro en la letra lo que se pide para el contador 
            //Por lo tanto implemente lo que entendí
            if(numero > 0) 
            {
                Console.WriteLine("El número es positivo");
                for(int i = numero; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("El número es negativo");
                for (int i = numero; i <= 0; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
