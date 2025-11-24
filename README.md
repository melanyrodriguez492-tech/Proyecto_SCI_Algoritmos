# Proyecto_SCI_Algoritmos
"Algoritmo para el Sistema Contra Incendio - Grupo 04 - Fundamentos de Algoritmos"

 ## Descripción del Proyecto
Este proyecto se enmarca dentro del curso de Fundamentos de Algoritmos y tiene como propósito el diseño, desarrollo e implementación de un algoritmo que simule la lógica del Panel Central de Alarma de Incendio 

### El objetivo 
Proteger los turbogeneradores de energía de cualquier incidencia que pueda desencadenar un amago de incendio , determinando la secuencia de eventos que activan los dispositivos anunciadores (Luces Estroboscópicas).
 
---------------------------------------------------

## Tecnologías y Herramientas Utilizadas

- Lenguaje de Programación: C# 
    - Implementado como una aplicación de Consola (.NET).
- Versionamiento: Git y GitHub.
    - Utilizado para el trabajo colaborativo y el control de versiones del código fuente.
- Editor/IDE: Visual Studio IDE.
- Gestión de Repositorio: GitHub Desktop (como interfaz gráfica de Git).

------------------------------------------------------------------

## Flujo del Algoritmo (Panel Central)
- Estados del Sistema de Monitoreo
1. Estado: Normal (Monitoreo)
- Evento/Lógica:
El panel monitorea de manera permanente a todos los dispositivos.
- Acción Clave del Sistema:
Muestra el menú de opciones.

2. Estado: Alarma Activa
- Evento/Lógica:
Se recibe información procedente de un sensor de humo, temperatura o una estación manual.
- Acción Clave del Sistema:
- Cambia el estado a ALARMA.
- Activa las luces estroboscópicas.

3. Estado: Falla
- Evento/Lógica:
Un dispositivo no responde (falla de sensor).
- Acción Clave del Sistema:
Muestra un aviso de mantenimiento sin activar la alarma general, evitando falsas alarmas.

4. Estado: Reinicio
- Evento/Lógica:
El usuario selecciona la opción RESET.
- Acción Clave del Sistema:
El sistema vuelve al estado Normal si la amenaza inicial ha cesado.

-------------------------------------------------------------------
## Instrucciones de Uso y Ejecución
1. Clonar el Repositorio:
- Copia la URL del repositorio.
Clona el proyecto usando GitHub Desktop o la línea de comandos (git clone [URL]).

2. Abrir en Visual Studio:
- Abre la solución SistemaSeguridadApp.sln dentro de la carpeta clonada en el Visual Studio IDE (2022 o similar).

3. Ejecución:
- Presiona F5 o haz clic en el botón "Start" para compilar y ejecutar el programa de consola.

4. Simular Eventos:
- Utiliza las opciones del menú numeradas del 1 al 6 para simular las condiciones de alarma (Humo, Temperatura), falla o reseteo del sistema.