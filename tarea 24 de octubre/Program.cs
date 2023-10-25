using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_24_de_octubre
{
    internal class Program
    {
        static int mPhoneStock = 0;
        static int mPadStock = 0;
        static int MAPBrookStock = 0;
        static int mWatchStock = 0;

        static int totalPhonesSold = 0;
        static int totalPadsSold = 0;
        static int totalMAPBrooksSold = 0;
        static int totalWatchesSold = 0;

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Productos de mPhone");
                Console.WriteLine("================================");
                Console.WriteLine("1: Ventas de mPhone 3000");
                Console.WriteLine("2: Ventas de mPad 3500");
                Console.WriteLine("3: Ventas de MAPBrook 3800");
                Console.WriteLine("4: Ventas de mWatch 8000");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        GestionarProducto("mPhone 3000");
                        break;
                    case 2:
                        GestionarProducto("mPad 3500");
                        break;
                    case 3:
                        GestionarProducto("MAPBrook 3800");
                        break;
                    case 4:
                        GestionarProducto("mWatch 8000");
                        break;
                    case 5:
                        MostrarResumenVentasDevoluciones();
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                        break;
                }
            }
        }

        static void GestionarProducto(string productName)
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Registrar Venta de {productName}");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar Venta");
                Console.WriteLine("2: Registrar Devolución");
                Console.WriteLine("3: Menu Principal");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        RegistrarVenta(productName);
                        break;
                    case 2:
                        RegistrarDevolucion(productName);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                        break;
                }
            }
        }

        static void RegistrarVenta(string productName)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Registrar venta de {productName}");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la venta de un {productName}");
            Console.WriteLine("¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                switch (productName)
                {
                    case "mPhone 3000":
                        mPhoneStock++;
                        totalPhonesSold++;
                        break;
                    case "mPad 3500":
                        mPadStock++;
                        totalPadsSold++;
                        break;
                    case "MAPBrook 3800":
                        MAPBrookStock++;
                        totalMAPBrooksSold++;
                        break;
                    case "mWatch 8000":
                        mWatchStock++;
                        totalWatchesSold++;
                        break;
                }
                Console.WriteLine("Venta registrada con éxito.");
            }
        }

        static void RegistrarDevolucion(string productName)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Registrar devolución de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la devolución de un {productName}");
            Console.WriteLine("¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                switch (productName)
                {
                    case "mPhone 3000":
                        if (mPhoneStock > 0)
                        {
                            mPhoneStock--;
                            totalPhonesSold--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                    case "mPad 3500":
                        if (mPadStock > 0)
                        {
                            mPadStock--;
                            totalPadsSold--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                    case "MAPBrook 3800":
                        if (MAPBrookStock > 0)
                        {
                            MAPBrookStock--;
                            totalMAPBrooksSold--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                    case "mWatch 8000":
                        if (mWatchStock > 0)
                        {
                            mWatchStock--;
                            totalWatchesSold--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                }
            }
        }

        static void MostrarResumenVentasDevoluciones()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Resumen de Ventas y Devoluciones:");
            Console.WriteLine($"Ventas de mPhone:             |        {totalPhonesSold}");
            Console.WriteLine($"Ventas de mPad:               |        {totalPadsSold}");
            Console.WriteLine($"Ventas de MAPBrook:           |        {totalMAPBrooksSold}");
            Console.WriteLine($"Ventas de mWatch:             |        {totalWatchesSold}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Devoluciones de mPhone:       |        {totalPhonesSold - mPhoneStock}");
            Console.WriteLine($"Devoluciones de mPad:         |        {totalPadsSold - mPadStock}");
            Console.WriteLine($"Devoluciones de MAPBrook:     |        {totalMAPBrooksSold - MAPBrookStock}");
            Console.WriteLine($"Devoluciones de mWatch:       |        {totalWatchesSold - mWatchStock}");
            Console.WriteLine("================================");
            Console.WriteLine("Diseñado por Fabrizzio Freddy Huarca Caldua");
            Console.WriteLine("================================");
            Console.WriteLine("  ");
        }
    }
}
