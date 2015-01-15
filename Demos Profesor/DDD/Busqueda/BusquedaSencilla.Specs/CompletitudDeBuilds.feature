#language: es

Característica: CompletitudDeBuilds
 Como un administrador de builds
 Quiero conocer cuáles soluciones .NET no tienen un Build
 Con el fin de valorar la completitud.

@mytag
Escenario: Hallar soluciones en un repositorio
	Dadas las siguientes soluciones
	| Ruta en el repositorio |
	| $/vss/proyecto1/proyecto1.sln |
	| $/vss/proyecto2/proyecto2.sln |
	| $/vss/proyecton/proyecton.sln |		
	Y los siguientes builds
	| Nombre del build | Ruta que monitorea |
	|proyecto1| $/vss/proyecto1/proyecto1.sln |
	|proyecto2| $/vss/proyecto2/proyecto2.sln |

	Cuando analizo la completitud
	Entonces las siguientes soluciones no tienen build
	| Ruta en el repositorio |
	| $/vss/proyecton/proyecton.sln |