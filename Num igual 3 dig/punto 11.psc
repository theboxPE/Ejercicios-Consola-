Algoritmo sin_titulo
	
	Definir a,d1,x1,d2,d3 Como Entero
	Escribir "Ingrese un numero de tres digitos"
	Leer a
	
	si a<1000 y a >99 Entonces
		d1 <- trunc (a/100)
		x1 <- a mod 100
		d2 <- trunc (x1/10)
		d3 <- x1 mod 10
		si d1 = d3 Entonces
			Escribir "Su primer digito es igual al ultimo "
		SiNo
			Escribir "Ingrese nuevo numero de tres digitos"
		FinSi
		
	FinSi
FinAlgoritmo
