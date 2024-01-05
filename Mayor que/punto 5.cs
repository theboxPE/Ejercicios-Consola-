//PROGRAMA QUE LEA DOS NÚMEROS Y DETERMINE CUAL ES EL MAYOR.

int a;
int b;

Console.WriteLine("Ingresa un primer valor");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un segundo valor");
b = Convert.ToInt32(Console.ReadLine());

if (a==b) {
	Console.WriteLine("Los numeros son iguales");
} else {
			
if (a!=b) {
	Console.WriteLine("El numero "+a+" es mayor");
} else {
	Console.WriteLine("El numero "+b+" es mayor");
}
}

Console.ReadKey();