// PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS Y DETERMINE SI AMBOS DÍGITOS SON PARES O IMPARES. DEBE MOSTRAR UN MENSAJE DANDO LA INFORMACIÓN DE CADA DÍGITO (DECIR: "EL 1ER DÍGITO ES __(PAR  O IMPAR), EL SEGUNDO...").

int a;
int b;
int n;

Console.WriteLine("ingresa un numero de 2 digitos");
n = Convert.ToInt32(Console.ReadLine());

if (n>9 && n<100) {

	a = (n/10);
	b = (n%10);

if (a%2==0 && b%2==0) {
Console.WriteLine("Ambos digitos son pares");

} else {
    if (a%2==0) {
	Console.WriteLine("El digito "+a+" es par");
	Console.WriteLine("El digito "+b+" es impar");
} else {
	if (b%2==0) {
	Console.WriteLine("El digito "+b+" es par");
	Console.WriteLine("El digito "+a+" es impar");
} else {
Console.WriteLine("Ningun digito es par");
}
}
}

} else {
	Console.WriteLine("Debe de ingresa un numero de 2 digitos");
}
	
Console.ReadKey();