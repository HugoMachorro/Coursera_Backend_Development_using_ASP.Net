# Modelo, Vista, Controlador

### MODELO

- Representa los datos o representa la forma de los datos.
- Es una clase que representa los datos y la lógica empresarial de la aplicación.

### VISTA

- La interfaz de usuario

### CONTROLADOR

- Principal manejador de solicitudes

* Manda lo "que requiere el usuario" al modelo y le regresa la respuesta.
* Devuelve al usuario final

<p align="center">
    <img width="30%" height="30%" src = "https://github.com/HugoMachorro/Coursera_Backend_Development_using_ASP.Net/assets/144370821/75b50a9c-3702-4305-8494-05d8f7639070"/>
</p>

#### Notas

- Razor view engine is a view engine used in ASP.NET Core for generating HTML markup using Razor syntax. [El motor de visualización Razor es un motor de visualización utilizado en ASP.NET Core para generar marcado HTML utilizando la sintaxis Razor.]
- Convention-based routing uses a set of conventions to define the URL structure, while attribute-based routing uses attributes to specify the URL structure. [El enrutamiento basado en convenciones utiliza un conjunto de convenciones para definir la estructura de la URL, mientras que el enrutamiento basado en atributos usa atributos para especificar la estructura de la URL.]

#### TempData

- TempData se utiliza para transferir los datos desde una solicitud a la siguiente solicitud, es decir, desde la vista hasta el controlador, controlador a la vista, o de un método de acción para otro método de acción del mismo o diferente controlador.

* TempData puede contener el valor para varias consultas sucesivas.

#### Sessions

Una sesión es una forma de conservar datos entre solicitudes para el mismo usuario, incluso si cierran su navegador o abandonar la aplicación.
