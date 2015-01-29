#language: es
Característica: Busqueda de restaurantes
	Como Rosa, la turista, 
	quiero buscar restaurantes de acuerdo a su tipo de comida.

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

Escenario: Búsqueda por tipos de restaurante
Cuando Rosa busca por “tica” 
Entonces "Doña Lela" es parte de los resultados
Pero "Ivonnes" no es parte de los resultados

