// PROGRAMA QUE LEA UN NUMERO ENTERO DE DOS DÍGITOS Y DETERMINE SI SUS DOS DÍGITOS SON IGUALES.
int a;
int b;
int n;

Console.WriteLine("ingresa un numero de 2 digitos");
n = Convert.ToInt32(Console.ReadLine());

if (n>9 && n<100) {

	a = (n/10);
	b = (n%10);

if (a%2==0 && b%2==0) {
Console.WriteLine("Ambos digitos son iguales");

} else {
    if (a%2!=b) {
	Console.WriteLine("Los digitos ingresados son diferentes");
	
} else {
	if (b%2!=a) {
	Console.WriteLine("Los digitos ingresados son diferentes");
	
} else {
Console.WriteLine("Ningun digito es par");
}
}
}

} else {
	Console.WriteLine("Debe de ingresa un numero de 2 digitos");
}
	
Console.ReadKey();
