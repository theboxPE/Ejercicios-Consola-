Algoritmo punto_3
	
	Definir num,dig1,dig2,sum Como Entero
	
	Escribir "Digite un numero entero de dos digitos"
	leer num
	
	si num<0
		num=num*(-1)
	FinSi
	
	si num>=10 y num<=99
		dig1=num-trunc(num/10)*10
		dig2=trunc(num/10)
		sum=dig1+dig2
		Escribir "La suma de los dos digitos del numero entero ingresado es: ", sum
	SiNo
		Escribir "El numero entero ingresado debe de ser de dos digitos"
	FinSi
	
FinAlgoritmo
