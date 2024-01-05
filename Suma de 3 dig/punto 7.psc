Algoritmo sin_titulo
	
	Definir num,num2,a,b,c,suma Como Entero
	
	Escribir "Ingrese un numero de 3 digitos: "
	Leer num
	
	num2 = (num)
	
	si num2>100 y num2<1000 Entonces
		a = num mod 10
		num = trunc(num/10)
		b = num mod 10
		num = trunc(num/10)
		c = num mod 10
		
		suma = a + b + c
		Escribir "La suma de los 3 numeros es: ",suma
	SiNo
		Escribir "El ", num, "no es de 3 digitos"
		
	FinSi
FinAlgoritmo
