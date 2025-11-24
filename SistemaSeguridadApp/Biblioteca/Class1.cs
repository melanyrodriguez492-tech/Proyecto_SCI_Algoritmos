using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class biblioteca
    {
        int opcion;
        bool estado_alarma_parpadeante = true;
        string[] mensaje = new string[6];
        

        //Estado de la alarma
        bool estado_alarma = false;

        //menu
        public void menu()
        {

            bool valor_bool = true;

            while (valor_bool)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n=============================================");
                Console.WriteLine("        PANEL DE CONTROL SCI - GRUPO '4'   ");
                Console.WriteLine("=============================================");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n--- ESTADO: NORMAL ---");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nMENSAJE: {mensaje}");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nSeleccione la acción a simular (Presione el número):");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("1. Simular Humo (Alarma Principal)");
                Console.WriteLine("2. Simular Temperatura Crítica (Alarma Principal)");
                Console.WriteLine("3. Simular Estación Manual Activada (Alarma Principal)");
                Console.WriteLine("4. Simular Falla de Sensor (Aviso de Mantenimiento)");
                Console.WriteLine("5. RESETEAR Sistema (Apagar Alarma)");
                Console.WriteLine("6. Salir de la simulación");
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("Seleccione una Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        alarma();
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

        //Alarma Activa
        public void comprobar_alarma()
        {
            if (estado_alarma == false)
            {
                estado_alarma = true;
            }
            else
            {
                Console.WriteLine("El sistema ya está con ALARMA ACTIVA. No se registra un nuevo evento principal.");
            }
        }

        //alarma (CHATGPT)
        public void alarma()
        {
            {
                comprobar_alarma();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n*** ESTADO: ALARMA ACTIVADA! ***");

                // Guardamos posición actual (para no pisar texto)
                int lineaSirena = Console.CursorTop;

                // Activamos la sirena en segundo plano, enviando la línea donde debe dibujarse
                estado_alarma_parpadeante = true;
                Thread hiloSirena = new Thread(() => sirena(lineaSirena));
                hiloSirena.IsBackground = true;
                hiloSirena.Start();

                // Ahora sí mostramos MENSAJE abajo sin interferencia
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nMENSAJE:");
                Console.ReadKey();

                estado_alarma_parpadeante = false;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //Sirena (CHATGPT)
        public void sirena(int linea)
        {
            {
                Console.Title = "Sirena Estroboscópica Simple";
                Console.CursorVisible = false;

                string barra = "    ███.███.███.███.███.███"; 
                int intervalo = 120; // velocidad del parpadeo

                while (estado_alarma_parpadeante)
                {
                    Console.SetCursorPosition(0, linea);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(barra);

                    Thread.Sleep(intervalo);

                    
                    Console.SetCursorPosition(0, linea);
                    Console.Write(new string(' ', barra.Length));

                    Thread.Sleep(intervalo);
                }
            }
        }

        //mensaje
        public void mensaje_opciones()
        {

            mensaje[0] = "Sistema SCI // Monitoreando...";
            mensaje[1] = "HUMOOOO";
            mensaje[2] = "TEMPERATURA CRITICA";
            mensaje[3] = "ESTACION MANUAL";
            mensaje[4] = "FALLO DE SENSOR";
            mensaje[5] = "Sistema SCI // Monitoreando...";

        }      
    }
}

