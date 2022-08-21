double VaTotal;
double Vbaboleta = 15000;

Console.WriteLine("Igrese su nombre completo");
String Nombre = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
uint edad = uint.Parse ( Console.ReadLine());


switch (edad){
 case < 4:
    Console.WriteLine("Nombre: " + Nombre + " | Edad: " + edad + " años.  la entrada es gratis " );
 break;

case <= 18:
    VaTotal = Vbaboleta*0.5;
    Console.WriteLine("Nombre: " + Nombre + " | Edad: " + edad + " años.  tienes un descuento del 5%.   valor a pagar " + VaTotal);
break;

case > 18:
  VaTotal = Vbaboleta*0.3;
  Console.WriteLine("Nombre: " + Nombre + " | Edad: " + edad + " años.  tienes un descuento del 3%.  valor a pagar " + VaTotal);
break;

}




