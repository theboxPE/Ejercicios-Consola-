Algoritmo sin_titulo
	definir x,n,a,b,c como real
	Escribir "Escribe tres numeros"
	Para x<-1 Hasta 3 Hacer
		Leer n
		Si x == 1 Entonces
			a = n
		FinSi
		Si x == 2 Entonces
			Si a < n Entonces
				b = a
				a = n
			SiNo
				b = n
			FinSi
		FinSi
		Si x == 3 Entonces
			Si a < n Entonces
				c = b
				b = a
				a = n
			SiNo
				Si b < n Entonces
					c = b
					b = n
				SiNo
					c = n
				FinSi
			FinSi
		FinSi
	FinPara
	Escribir c
	Escribir b
	Escribir a
FinAlgoritmo
