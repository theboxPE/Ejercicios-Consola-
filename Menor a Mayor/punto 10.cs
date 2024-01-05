// PROGRAMA QUE LEA TRES NÚMEROS Y LOS MUESTRE EN ORDEN ASCENDENTE (DE MENOR A MAYOR)
double a;
double b;
double c;
double n;
double x;

Console.WriteLine("Escribe tres numeros");

a = 0;
b = 0;
c = 0;

for (x=1;x<=3;x++) {
	n = Convert.ToDouble(Console.ReadLine());
if (x == 1) {
    a = n;
}

if (x == 2) {
	if (a< n) {
	b = a;
	a = n;
} else {
	b = n;
}
 }
				
if (x == 3) {
	if (a < n) {
	c = b;
	b = a;
	a = n;
} else {
	if (b < n) {
	c = b;
	b = n;
} else {
	c = n;
}
 }
  }
   } 

Console.WriteLine("Los numeros ingresados ordenados son: ");
Console.WriteLine(c);
Console.WriteLine(b);
Console.WriteLine(a);
		
Console.ReadKey();