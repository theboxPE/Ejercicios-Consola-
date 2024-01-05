// PROGRAMA QUE LEA UN NUMERO ENTERO DE TRES DIGITOS  Y DETERMINE SI EL PRIMERO ES IGUAL AL ULTIMO.
int a;
int d1;
int d2;
int d3;
int x1;

Console.WriteLine("Ingrese un numero de tres digitos");
a = Convert.ToInt32(Console.ReadLine());

if (a<1000 && a>99) {
	d1 = (a/100);
	x1 = (a%100);
	d2 = (x1/10);
	d3 = (x1%10);

if (d1==d3) {
	Console.WriteLine("Su primer digito es igual al ultimo ");
} else {
	Console.WriteLine("Ingrese un nuevo numero de tres digitos"); 
}
}

Console.ReadKey();