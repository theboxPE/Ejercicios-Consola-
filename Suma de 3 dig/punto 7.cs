// PROGRAMA QUE LEA UN NUMERO DE TRES DÍGITOS (DEBE VALIDAR ESA ENTRADA) Y CALCULE LA SUMATORIA DE SUS DÍGITOS
int a;
int b;
int c;
int num;
int num2;
int suma;
			
Console.WriteLine("Ingrese un numero de 3 digitos: ");
num = Convert.ToInt32(Console.ReadLine());

num2 = (num);

if (num2>100 && num2<1000) {
a = num%10;
num = (num/10);
b = num%10;
num = (num/10);
c = num%10;

suma = a+b+c;

Console.WriteLine("La suma de los 3 numeros es: "+ suma);
} else {
Console.WriteLine("El "+ num +"no es de 3 digitos");
}

Console.ReadKey();