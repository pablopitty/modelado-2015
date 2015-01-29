#language: es
Característica: Busqueda de restaurantes
	Como Rosa, la turista, 
	quiero buscar restaurantes de acuerdo a mi tipo de comida favorita en mi ciudad.

Antecedentes:
Dados estos restaurantes
 		|Nombre | Tipo de comida | Tipo de restaurant| Ubicación |
		|Ivonnes  | sushi | gourmet| San José|
		|McDonalds  | hamburguesas | rapida| San José |
		|Machupichu | peruana | gourmet | Heredia|
		|Machupichu | peruana | gourmet | Alajuela|
		|Spoon | variada | casual | San José|
		|Doña Lela | tica, típica | casual | Pavas|
Y sabemos que Ivonne busca desde "San José" 

Escenario: Búsqueda por tipo de comida exitosa
Cuando Rosa busca por “sushi” 
Entonces "Ivonnes" es parte de los resultados.

Escenario: Búsqueda de los 10 restaurantes mas cercanos
Cuando Rosa busca por “variada” 
Entonces "Spoon" es parte de los resultados
Y "McDonalds" es parte de los resultados
Y "Ivonnes" es parte de los resultados
Pero "Machupichu" no es parte de los resultados

Escenario: Búsqueda por tipos de restaurante
Cuando Rosa busca por “tica” 
Entonces "Doña Lela" es parte de los resultados
Pero "Ivonnes" no es parte de los resultados

