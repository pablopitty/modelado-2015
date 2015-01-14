#language: es

Característica: Cajero
	Como Pedro, el cliente
	Quiero Hacer un retiro de la cuenta
	Con el fin de tener efectivo.

@retiros
Escenario: Retiro exitoso
Dado Una cuenta con saldo 100 dólares
Cuando se hace un retiro de 55 dólares.
Entonces el saldo restante es de 45 dólares.

@retiros
Escenario: Retiro sin saldo
Dado Una cuenta con saldo 0 dólares
Cuando se hace un retiro de 55 dólares.
Entonces el saldo restante es de 0 dólares.

@retiros
Escenario: Retiro sin fondos suficientes
Dado Una cuenta con saldo 200 dólares
Cuando se hace un retiro de 550 dólares.
Entonces el saldo restante es de 200 dólares.