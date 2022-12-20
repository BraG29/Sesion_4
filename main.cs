using ejercicio_1;
using ejercicio_2;
using ejercicio_3;

internal class main
{
    public static void Main(string[] args)
    {
        int opcion = -1;
        do
        {
            printMenu();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número entero: ");
                    Ejercicio1.ejercicio1(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Ingrese un número entero: ");
                    Ejercicio2.ejercicio2(int.Parse(Console.ReadLine()));
                    break;

                case 3:
                    int alto, ancho;
                    string opRellena, opCantDibujos;
                    bool relleno = false;
                    Console.Write("Ingrese una altura: ");
                    alto = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ancho: ");
                    ancho = int.Parse(Console.ReadLine());
                    Console.Write("Desea que la figura sea rellena? (s/n): ");
                    opRellena = Console.ReadLine();
                    if (opRellena == "s")
                        relleno = true;
                    Console.Write("Desea dibujar la figura mas de una vez? (s/n): ");
                    opCantDibujos = Console.ReadLine();
                    if (opCantDibujos == "n")
                        Ejercicio3.ejercicio3(alto, ancho, relleno);
                    else
                    {
                        int cantDibujos;
                        Console.Write("Cuantas veces desea dibujar la figura?: ");
                        cantDibujos = int.Parse(Console.ReadLine());
                        Ejercicio3.ejercicio3(alto, ancho, cantDibujos, relleno);

                    }
                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("La opcion no es correcta. Intentelo de nuevo");
                    break;
            }

        } while (opcion != 0);
    }

    public static void printMenu()
    {
        Console.WriteLine("Ingrese una opción numerica:" +
            "\n1- Ejercicio 1" +
            "\n2- Ejercicio 2" +
            "\n3- Ejercicio 3" +
            "\n0- Salir");
    }
}
