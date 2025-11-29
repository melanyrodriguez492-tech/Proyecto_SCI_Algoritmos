using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaSeguridadApp
{
    internal class Program
    {
        static int opcion;
        static bool estado_alarma_parpadeante = false;
        static bool estado_alarma = false;
        static string[] mensaje = new string[6];


        //MENSAJE DE ENCABEZADO
        static string mensaje_fijo = ("Sistema SCI // Monitoreando...");

        //MENU
        static void Main(string[] args)
        {

            mensaje_opciones();
            bool valor_bool = true;

            while (valor_bool)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n=============================================");
                Console.WriteLine("        PANEL DE CONTROL SCI - GRUPO '4'   ");
                Console.WriteLine("=============================================");


                if (estado_alarma)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n==============================================");
                    Console.WriteLine("       *** ESTADO: ALARMA ACTIVADA! ***   ");
                    Console.WriteLine("==============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n==============================================");
                    Console.WriteLine("            *** ESTADO: NORMAL ***   ");
                    Console.WriteLine("==============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nMENSAJE: {mensaje_fijo}");

                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n--- [ PRUEBAS DE SENSORES ] ---");
                Console.ResetColor();
                Console.WriteLine("1. Activar Sensor de HUMO (Zona Turbinas)");
                Console.WriteLine("2. Activar Sensor de TEMPERATURA (Zona Generador)");
                Console.WriteLine("3. Activar Estación MANUAL (Pasillo)");

                // Sección 2: Mantenimiento y Fallas
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n--- [ MANTENIMIENTO ] ---");
                Console.ResetColor();
                Console.WriteLine("4. Reportar FALLA técnica (Sensor averiado)");

                // Sección 3: Control del Sistema
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n--- [ CONTROL DEL SISTEMA ] ---");
                Console.ResetColor();
                Console.WriteLine("5. REINICIAR Sistema (Apagar Alarmas)");
                Console.WriteLine("6. SALIR del Simulador");

                Console.WriteLine("\n==========================================");
                Console.Write("Ingrese el número de la acción a realizar: ");


                opcion = LeerOpcion(1, 6);
              

                switch (opcion)
                //Dependiendo del número que el usuario haya elegido (entre 1 y 6), se ejecutará el bloque correspondiente.
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
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nMENSAJE: {mensaje[1]}");
                            mensaje_fijo = mensaje[1];
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 2:
                        if (estado_alarma)
                        {
                            comprobar_alarma();
                        }
                        else
                        {
                            post_seleccion();
                            activar_alarma();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nMENSAJE: {mensaje[2]}");
                            mensaje_fijo = mensaje[2];
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 3:
                        if (estado_alarma)
                        {
                            comprobar_alarma();
                        }
                        else
                        {
                            post_seleccion();
                            activar_alarma();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nMENSAJE: {mensaje[3]}");
                            mensaje_fijo = mensaje[3];
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 4:
                        if (estado_alarma)
                        {
                            comprobar_alarma();
                        }
                        else
                        {
                            post_seleccion();
                            activar_alarma();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nMENSAJE: {mensaje[4]}");
                            mensaje_fijo = mensaje[4];
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 5:

                        if (estado_alarma == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            Console.WriteLine("\n=============================================");
                            Console.WriteLine("         EL SISTEMA NO ESTÁ ACTIVADO         ");
                            Console.WriteLine("=============================================");

                            Console.ForegroundColor = ConsoleColor.White;
                            mensaje_fijo = mensaje[0];
                        }
                        else
                        {
                            estado_alarma = false;
                            estado_alarma_parpadeante = false;
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("\n=============================================");
                            Console.WriteLine("       REINICIANDO SISTEMA (Modo Normal)   ");
                            Console.WriteLine("=============================================");

                            Console.ForegroundColor = ConsoleColor.White;
                            mensaje_fijo = mensaje[0];
                        }

                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n==============================================");
                        Console.WriteLine("           SALIENDO DEL PROGRAMA...   ");
                        Console.WriteLine("==============================================");
                        Console.ForegroundColor = ConsoleColor.White;
                        valor_bool = false;
                        break;
                    default:
                        Console.WriteLine("\nEscoja una opción valida");
                        break;
                }

                Console.ReadKey();
                estado_alarma_parpadeante = false;
                Console.Clear();
            }
        }

        static void mensaje_opciones()
        {
            mensaje[0] = "Sistema SCI // Monitoreando...";
            mensaje[1] = "ALARMA DE HUMO DETECTADA en Zona de Turbina A.";
            mensaje[2] = "ALARMA DE TEMPERATURA CRÍTICA DETECTADA en Zona de Generador Auxiliar.";
            mensaje[3] = "ALARMA DE ESTACIÓN MANUAL DETECTADA en Pasillo de Emergencia.";
            mensaje[4] = "Sensor de Humo no responde en Zona 1. Contacte a mantenimiento";
        }

        // CAMBIA ESTADO DE ALARMA
        static void comprobar_alarma()
        {
            if (estado_alarma == false)
            {
                estado_alarma = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n==============================================");
                Console.WriteLine("     El sistema ya está con ALARMA ACTIVA   ");
                Console.WriteLine("==============================================");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }



        // MENSAJE DE ALARMA ACTIVA
        static void post_seleccion()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n==============================================");
            Console.WriteLine("       *** ESTADO: ALARMA ACTIVADA! ***   ");
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void activar_alarma()
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


        //MENSAJES



        static void alarma(int lineaSirena)
        {
            Console.CursorVisible = false;

            string barra = "          .███.███.███.███.███.███.";
            int intervalo = 200;

            while (estado_alarma_parpadeante)
            {
                Console.SetCursorPosition(0, lineaSirena);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(barra);

                Thread.Sleep(intervalo);

                Console.SetCursorPosition(0, lineaSirena);
                Console.Write(new string(' ', barra.Length));

                Thread.Sleep(intervalo);

                Console.Beep(1000, 150);

            }

            Console.ResetColor();
            Console.CursorVisible = true;
        }

        static int LeerOpcion(int minValor, int maxValor)
        {
            int valor;
            while (true)
            {
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Entrada vacía. Introduzca un número entre {minValor} y {maxValor}:");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (!int.TryParse(entrada.Trim(), out valor))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Entrada no numérica. Introduzca un número entre {minValor} y {maxValor}:");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (valor < minValor || valor > maxValor)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Opción fuera de rango. Introduzca un número entre {minValor} y {maxValor}:");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                return valor;
            }
        }
        
    }
}