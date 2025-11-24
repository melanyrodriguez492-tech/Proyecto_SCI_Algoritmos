using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class biblioteca
    {
        public void menu()
        {

            bool valor_bool = true;

            while (valor_bool)
            {
                Console.WriteLine("Seleccione la acción a simular (Presione el número):");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("1. Simular Humo (Alarma Principal)");
                Console.WriteLine("2. Simular Temperatura Crítica (Alarma Principal)");
                Console.WriteLine("3. Simular Estación Manual Activada (Alarma Principal)");
                Console.WriteLine("4. Simular Falla de Sensor (Aviso de Mantenimiento)");
                Console.WriteLine("5. RESETEAR Sistema (Apagar Alarma)");
                Console.WriteLine("6. Salir de la simulación");
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("Seleccione una Opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        valor_bool = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            }
        }

        
    }
}
