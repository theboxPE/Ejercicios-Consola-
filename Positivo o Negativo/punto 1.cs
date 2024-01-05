// PROGRAMA QUE LEA UN NUMERO Y DETERMINE SI ES POSITIVO O NEGATIVO, MOSTRANDO UN MENSAJE PARA CADA CASO.

int num;

Console.WriteLine("Ingresa el numero a determinar");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0) {

Console.WriteLine("El numero es positivo");
} else {
Console.WriteLine("El numero es negativo");
}

Console.ReadKey();