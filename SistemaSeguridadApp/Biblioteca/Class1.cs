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
        bool estado_alarma_parpadeante = false;
        bool estado_alarma = false;
        string[] mensaje = new string[6];

        // MENU PRINCIPAL
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
                Console.WriteLine("\nMENSAJE: (ninguno)");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nSeleccione la acción a simular:");
                Console.WriteLine("1. Simular Humo (Alarma Principal)");
                Console.WriteLine("2. Simular Temperatura Crítica (Alarma Principal)");
                Console.WriteLine("3. Simular Estación Manual Activada (Alarma Principal)");
                Console.WriteLine("4. Simular Falla de Sensor (Aviso de Mantenimiento)");
                Console.WriteLine("5. RESETEAR Sistema (Apagar Alarma)");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (estado_alarma)
                        {
                            comprobar_alarma();
                        }
                        else
                        {
                            post_seleccion();
                            activar_alarma();
                            Console.WriteLine("\nHola");
                        }
                        break;

                    case 5:
                        estado_alarma = false;
                        estado_alarma_parpadeante = false;
                        Console.WriteLine("Sistema reseteado");
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        valor_bool = false;
                        break;
                }

                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
                estado_alarma_parpadeante = false;
                Console.Clear();
            }
        }

        // PANTALLA DE ALARMA
        public void post_seleccion()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n=============================================");
            Console.WriteLine("        PANEL DE CONTROL SCI - GRUPO '4'   ");
            Console.WriteLine("=============================================");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n*** ESTADO: ALARMA ACTIVADA! ***");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // CAMBIA ESTADO DE ALARMA
        public void comprobar_alarma()
        {
            if (estado_alarma == false)
            {
                estado_alarma = true;
            }
            else
            {
                Console.WriteLine("El sistema ya está con ALARMA ACTIVA.");
            }
        }

        // SIRENA HORIZONTAL (CHATGPT)
        public void alarma(int lineaSirena)
        {
            Console.CursorVisible = false;

            string barra = "   .███.███.███.███.███.███.";
            int intervalo = 120;

            while (estado_alarma_parpadeante)
            {
                Console.SetCursorPosition(0, lineaSirena);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(barra);

                Thread.Sleep(intervalo);

                Console.SetCursorPosition(0, lineaSirena);
                Console.Write(new string(' ', barra.Length));

                Thread.Sleep(intervalo);
            }

            Console.ResetColor();
            Console.CursorVisible = true;
        }

        // ACTIVAR ALARMA (CHATGPT)
        public void activar_alarma()
        {
            comprobar_alarma();
            

            int lineaSirena = Console.CursorTop;

            estado_alarma_parpadeante = true;
            Thread hilo = new Thread(() => alarma(lineaSirena));
            hilo.IsBackground = true;
            hilo.Start();

            Console.SetCursorPosition(0, lineaSirena + 0);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }




    }

}

