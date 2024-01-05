Algoritmo sin_titulo
	Definir n,a,b Como Entero
	Escribir "ingresa un numero"
	Leer n
	
	si n > 9 y n < 100 Entonces
		a = trunc(n/10)
		b = n mod 10
		si a mod 2 == 0 y b mod 2 == 0 Entonces
			Escribir "Ambos digitos son pares"
		SiNo
			si a mod 2 <> 0 Entonces
				Escribir "Los digitos ingresados son diferentes"
				
			SiNo
				si b mod 2 <> 0 Entonces
					Escribir "Los digitos ingresados son diferentes"
					
				sino 
					Escribir "Ningun digito es par"
				FinSi
			FinSi
		FinSi
	SiNo
		Escribir "Ingresa un numero de 2 digitos"
	FinSi
	
	
FinAlgoritmo
