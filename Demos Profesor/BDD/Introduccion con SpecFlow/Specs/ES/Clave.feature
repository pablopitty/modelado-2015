Feature: Password
	As ChefJuan
	I want to iniciar sesión
	In order to registrar mis observaciones.

	
@sesion
Escenario: ChefJuan aprende a iniciar sesión en el sistema

Dado un usuario existente en el sistema: 
| Nombre | Fecha de Ingreso | Cantidad de recomendaciones | Clave | 
| ChefJuan | 2/2/2014 | 1 | Chef | 

Cuando inicia sesion con una clave Chef
Entonces puede iniciar sesion en el sistema