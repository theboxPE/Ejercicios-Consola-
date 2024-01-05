// PROGRAMA QUE LEA DOS NÚMEROS Y DETERMINE SI LA SUMATORIA DE AMBOS NÚMEROS ES PAR O IMPAR

int a;
int b;
int sum;

Console.WriteLine("Ingrese un primer valor");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un segundo valor");
b = Convert.ToInt32(Console.ReadLine());
			
sum = a+b;

Console.WriteLine("La suma de los numeros es: "+sum);
			
if (sum%(2)==0) {
Console.WriteLine("La suma de los numeros es Par");
} else {
Console.WriteLine("La suma de los numeros es impar");
}

Console.ReadKey();