/*Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, 
un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.*/

namespace ejercicio_3
{
    public class Ejercicio3
    {
        public static void ejercicio3(int alto, int ancho, bool relleno)
        {
            if(relleno)
            {
                for(int i = 1; i <= alto; i++)
                {
                    for(int j = 1; j <= ancho; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= alto; i++)
                {
                    for (int j = 1; j <= ancho; j++)
                    {
                        if(i == 1 || i == alto || j == 1 || j ==ancho)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }

            }
        }

        public static void ejercicio3(int alto, int ancho, int cantFiguras, bool relleno)
        {
            for(int i = 1; i <= cantFiguras; i++) 
            {
                if (i > 1)
                    Console.WriteLine();
                Console.WriteLine("Dibujo nro " + i);
                ejercicio3(alto, ancho, relleno);
            }
        }
    }

}

