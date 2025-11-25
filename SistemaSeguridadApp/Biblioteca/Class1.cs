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

        //MENSAJE DE ENCABEZADO
        string mensaje_fijo = ("Sistema SCI // Monitoreando...");
        
        string[] mensaje = new string[6];




        //NO BORRAR VACIOS (ORDEN VISUAL)



        // MENU PRINCIPAL
        public void menu()
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
                    Console.WriteLine("\n*** ESTADO: ALARMA ACTIVADA! ***");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--- ESTADO: NORMAL ---");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nMENSAJE: {mensaje_fijo}");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nSeleccione la acción a simular:");
                Console.WriteLine("1. Simular Humo (Alarma Principal)");
                Console.WriteLine("2. Simular Temperatura Crítica (Alarma Principal)");
                Console.WriteLine("3. Simular Estación Manual Activada (Alarma Principal)");
                Console.WriteLine("4. Simular Falla de Sensor (Aviso de Mantenimiento)");
                Console.WriteLine("5. RESETEAR Sistema (Apagar Alarma)");
                Console.WriteLine("6. Salir");
                Console.Write("\nSeleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

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
                        estado_alarma = false;
                        estado_alarma_parpadeante = false;
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("\n=============================================");
                        Console.WriteLine("       REINICIANDO SISTEMA (Modo Normal)   ");
                        Console.WriteLine("=============================================");

                        Console.ForegroundColor = ConsoleColor.White;
                        mensaje_fijo = mensaje[0];
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

                Console.WriteLine("\n\nPresione ENTER para continuar...");
                Console.ReadKey();
                estado_alarma_parpadeante = false;
                Console.Clear();
            }
        }




        //NO BORRAR VACIOS (ORDEN VISUAL)



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





        //NO BORRAR VACIOS (ORDEN VISUAL)






        // CAMBIA ESTADO DE ALARMA
        public void comprobar_alarma()
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




        //NO BORRAR VACIOS (ORDEN VISUAL)




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

                Console.Beep(1500, 120);
                Console.Beep(100, 500); 
                
            }

            Console.ResetColor();
            Console.CursorVisible = true;
        }





        //NO BORRAR VACIOS (ORDEN VISUAL)





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




        //NO BORRAR VACIOS (ORDEN VISUAL)




        //MENSAJES
        public void mensaje_opciones()
        {

            mensaje[0] = "Sistema SCI // Monitoreando...";
            mensaje[1] = "ALARMA DE HUMO DETECTADA en Zona de Turbina A.";
            mensaje[2] = "ALARMA DE TEMPERATURA DETECTADA en Zona de Generador Auxiliar.";
            mensaje[3] = " ALARMA DE ESTACIÓN MANUAL DETECTADA en Pasillo de Emergencia.";
            mensaje[4] = "Sensor de Humo no responde en Zona 1. Contacte a mantenimiento";
            mensaje[5] = "Sistema SCI // Monitoreando...";

        }
    }
}

