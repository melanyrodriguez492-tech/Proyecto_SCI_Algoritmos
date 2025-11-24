using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace SistemaSeguridadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            biblioteca x = new biblioteca();
        
            x.menu();
            

        }
    }

}




/*
static void Main(string[] args)
{
    // Instancia del Panel Central (creamos el objeto)
    PanelCentral panel = new PanelCentral();

    while (true)
    {
        Console.WriteLine("Seleccione la acción a simular (Presione el número):");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("1. Simular Humo (Alarma Principal)");
        Console.WriteLine("2. Simular Temperatura Crítica (Alarma Principal)");
        Console.WriteLine("3. Simular Estación Manual Activada (Alarma Principal)");
        Console.WriteLine("4. Simular Falla de Sensor (Aviso de Mantenimiento)");
        Console.WriteLine("5. RESETEAR Sistema (Apagar Alarma)");
        Console.WriteLine("6. Salir de la simulación");
        Console.Write("\nOpción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                panel.ActivarAlarma("HUMO", "Zona de Turbina A");
                break;
            case "2":
                panel.ActivarAlarma("TEMPERATURA", "Zona de Generador Auxiliar");
                break;
            case "3":
                panel.ActivarAlarma("ESTACIÓN MANUAL", "Pasillo de Emergencia");
                break;
            case "4":
                panel.RegistrarFalla("Sensor de Humo", "Zona 1");
                break;
            case "5":
                panel.ResetearSistema();
                break;
            case "6":
                return; // Sale del programa
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }

        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
        panel.MostrarEstado(); // Vuelve a mostrar el estado después de limpiar la consola
    }

}
}


public class PanelCentral
{
// PROPIEDADES (El Estado Actual del Sistema)
private bool enAlarma;
private string mensajePantalla;

// CONSTRUCTOR
public PanelCentral()
{
    enAlarma = false;
    mensajePantalla = "Sistema SCI: Modo Normal (Monitoreando...)";
    Console.Clear();
    MostrarEstado();
}

// MÉTODO para mostrar el estado actual
public void MostrarEstado()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n=============================================");
    Console.WriteLine("        PANEL DE CONTROL SCI - GRUPO JJM     ");
    Console.WriteLine("=============================================");

    // Muestra el estado del sistema
    if (enAlarma)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n*** ESTADO: ALARMA ACTIVADA! ***");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n--- ESTADO: NORMAL ---");
    }

    // Muestra el mensaje detallado del evento
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\nMENSAJE: {mensajePantalla}");

    // Simulación de las Luces Estroboscópicas
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(enAlarma ? ">> LUCES ESTROBOSCÓPICAS: ENCENDIDAS <<" : ">> LUCES ESTROBOSCÓPICAS: APAGADAS <<");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("=============================================\n");
}

// LÓGICA 1: ACTIVACIÓN DE ALARMA
public void ActivarAlarma(string tipoSensor, string zona)
{
    if (!enAlarma)
    {
        enAlarma = true;
        mensajePantalla = $"ALARMA DE {tipoSensor.ToUpper()} DETECTADA en {zona}.";
        Console.Beep(500, 1000); // Simulación de sonido de alarma
        MostrarEstado();
    }
    else
    {
        Console.WriteLine("El sistema ya está en ALARMA. No se registra un nuevo evento principal.");
    }
}

// LÓGICA 2: REGISTRO DE FALLA (No es alarma de incendio)
public void RegistrarFalla(string componente, string zona)
{
    if (!enAlarma)
    {
        mensajePantalla = $"FALLA DE SISTEMA: {componente} no responde en {zona}. Contacte a mantenimiento.";
        MostrarEstado();
    }
    else
    {
        // Si ya hay alarma, la falla se registra como un evento secundario.
        Console.WriteLine($"ADVERTENCIA: Falla de {componente} registrada durante la ALARMA.");
    }
}

// LÓGICA 3: REINICIO DEL SISTEMA
public void ResetearSistema()
{
    if (enAlarma)
    {
        enAlarma = false;
        mensajePantalla = "Sistema Reiniciado. Volviendo al Modo Normal (Monitoreando...)";
        MostrarEstado();
    }
    else
    {
        mensajePantalla = "El sistema ya está en Modo Normal.";
        MostrarEstado();
    }
}*/