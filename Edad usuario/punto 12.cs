// PROGRAMA QUE LEA LA EDAD DEL USUARIO. SI ES MAYOR QUE 50 MOSTRAR MENSAJE QUE DIGA "ABUELO." SI ES MAYOR QUE 30 MOSTRAR MENSAJE QUE DIGA "PADRE". EN CASO CONTRARIO MOSTRAR MENSAJE QUE DIGA "HIJO"

int edad;

Console.WriteLine("Ingrese su edad:");
edad = Convert.ToInt32(Console.ReadLine());

if(edad > 50){
    Console.WriteLine("Es abuelo");
}
else if (edad > 30 && edad < 50){
    Console.WriteLine("Es padre");
}
else{
    Console.WriteLine("Es hijo");
}

Console.ReadKey();
