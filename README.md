1.	ClubDeportivoWinForms  
**Materia:** Desarrollo de Sistemas Orientado a Objetos – 1°B  
**Instituto:** Agencia de Habilidades para el Futuro  
**Autor:** Ángel Domínguez  
**Versión:** 1.0 – octubre 2025  

2.	Objetivo del Proyecto
El propósito de este trabajo es **desarrollar un sistema de escritorio en C# con Windows Forms** que gestione la información de un **Club Deportivo**, aplicando los principios de la **Programación Orientada a Objetos (POO)**.
El proyecto evoluciona de la versión *ClubDeportivoConsole*, incorporando una **interfaz gráfica de usuario (GUI)** para mejorar la interacción y la usabilidad del sistema.

3.	Descripción General
El sistema permite administrar de forma visual los datos del club, incluyendo:
- Registro, modificación y eliminación de socios.  
- Asignación de actividades deportivas y profesores.  
- Control de cuotas y pagos.  
- Visualización de listados en formularios con **grillas de datos (DataGridView)**.  
Se utilizan formularios, controles gráficos y estructuras de datos encapsuladas mediante clases.

4.	Estructura del Sistema
- **FormPrincipal.cs:** Ventana principal del sistema.  
- **FormSocios.cs / FormActividades.cs:** Formularios secundarios para gestión específica.  
- **Clases de Dominio:** Socio, Actividad, Profesor, Club.  
- **Colecciones:** Listas genéricas (`List<T>`) para almacenar los objetos.

5.	Clases Principales
| Clase       | Descripción                            | Atributos relevantes |
| `Socio`     | Representa a un socio del club.        | nombre, documento, cuotaPaga |
| `Actividad` | Representa una disciplina o actividad. | nombre, profesor, cupoMaximo |
| `Profesor`  | Instructor a cargo de una actividad.   | nombre, especialidad |
| `Club`      | Administra colecciones y operaciones.  | listaSocios, listaActividades |

---

6.	Interfaz Gráfica
El sistema está desarrollado con **Windows Forms**, aplicando los principios vistos en el módulo *Interface de Usuario (Entorno Visual) *:
- Controles de entrada: `TextBox`, `ComboBox`, `DateTimePicker`.  
- Controles de comando: `Button`, `MenuStrip`.  
- Visualización de datos: `DataGridView`.  
- Ventanas modales y no modales (`Show()` / `ShowDialog()`).

7. Tecnologías Utilizadas
- **Lenguaje:** C# (.NET Framework / .NET 6+)  
- **Entorno de desarrollo:** Visual Studio  
- **Paradigma:** Programación Orientada a Objetos (POO)  
- **Control de versiones:** Git y GitHub  

8. Resultados Esperados
- Implementar correctamente los principios de POO en un entorno visual.  
- Integrar lógica de negocio y capa de presentación.  
- Utilizar controles gráficos de Windows Forms y manejo de eventos.  
- Aplicar modularización y reutilización de código.  

9.  Integrantes
Adriana Lazzeretti, Angel Dominguez, Gislena Gil Lopez, Gloria Escobar Karen Florindez

10. Licencia
Uso libre con fines educativos y de formación técnica.  
