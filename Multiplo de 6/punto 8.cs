// PROGRAMA QUE LEA UN NUMERO Y DETERMINE SI ES MÚLTIPLO DE 6.
int n;
Console.WriteLine("Ingrese un numero");

n = Convert.ToInt32(Console.ReadLine());

if (n%3==0) {
	Console.WriteLine("El numero "+n+" es multiplo de 6");
} else {
	Console.WriteLine("El numero "+n+" no es multiplo de 6");
     }

     Console.ReadKey();