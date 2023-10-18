### Middleware

- Proporciona una forma de procesar solicitudes y respuestas en proceso cada vez que un usuario envia una solicitud.
- Cada reques llega a traves de un pipeline.
- Middleware es un componente que se compone de una o mas funciones delegadas.
- Los componentes individuales que componene un pipeline se llama Middleware.

1. La solicitude HTTP llega al servidor de aplicacion.
2. Kestrel obtiene la solicitud.
3. Crea un HTTPContext y lo envia al primer middleware en el proceso de solicitud.
4. Hasta llegar al ultimo Middleware.
5. Devuleve la respuesta y llega al servidor Kestrel

### Built-In Middleware and custom Middleware

#### Built-In Middleware

- Authentication:
- CORS: Middleware de intercambio de solicitudes de origen cruzado
- Diagnostics
- HTTPS Redirection
- Request Localization
- Routing
- HTTP Method Override
- MVC
- Custom Middleware

#### Dependency Injection (DI)

- Se utiliza para lograr una arquitectura debilmente acoplada mientras desarrollas aplicaciones centrales .NET que hace una asociacion entre objetos.
- Ayuda en el desarrollo de una aplicacion basada en arquitectura debilmente acoplada donde los objetos no estan completamente dependenpientes unos de otros.

#### Autenticación

- Es el proceso de comprobar la identidad de un usuario en funcion de las credenciales del usuario.

1. Windows Authentication: cuando estamos creando una aplicación web para un numero limitado de usuarios que ya tienen cuenta de winwos
2. Form Authentication: se bada en cookies, por lo que proporciona una manera de manejar la autenticación usando tu propia lógica personalizada.
3. Passport Authentication: es un servicio de autenticacion centralizado proporcionado por Microsoft donde hay un concepto de servicio de inicio de sesion unico

#### Autorización

- es en realidad el proceso de comprobar si el usuario tiene acceso a los recursos que solicitó o no.
