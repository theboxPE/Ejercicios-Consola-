// PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS Y DETERMINE SI UN DÍGITO ES MÚLTIPLO DE OTRO
int num1;
int num2;

Console.WriteLine("Ingrese un numero");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingrese un segundo numero");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1%num2==0) {
	Console.WriteLine("El numero " + num1 + " es multiplo de " + num2);
} else {
	Console.WriteLine("El numero " + num1 + " no es multiplo de " + num2);
	}

Console.ReadKey();