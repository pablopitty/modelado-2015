#language: es
Característica: Busqueda de restaurantes
	Como Rosa, la turista, 
	quiero buscar restaurantes de acuerdo a cercanía a mi ciudad.

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

Escenario: Búsqueda de los 10 restaurantes mas cercanos
Cuando Rosa busca por “variada” 
Entonces "Spoon" es parte de los resultados
Y "McDonalds" es parte de los resultados
Y "Ivonnes" es parte de los resultados
Pero "Machupichu" no es parte de los resultados
