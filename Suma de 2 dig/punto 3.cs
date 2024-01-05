//PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS QUE DETERMINE LA SUMA DE LOS DOS DÍGITOS.

int dig1;
int dig2;
int num;
int sum;

Console.WriteLine("Digite dos numero entero de dos digitos");
num =Convert.ToInt32(Console.ReadLine());

if (num<0) {
	num = num*(-1);
}
if (num>=10 && num<=99) {
	dig1 = num-(num/10)*10;
	dig2 = (num/10);
	sum = dig1+dig2;
	Console.WriteLine("La suma de los dos digitos del numero entero ingresado es: "+sum);

} else {
	Console.WriteLine("El numero entero ingresado debe de ser de dos digitos");
}

Console.ReadKey();