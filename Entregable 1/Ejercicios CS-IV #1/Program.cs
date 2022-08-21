double RentaTotal;
Double RentaA;
int opcion;

 Console.WriteLine("____IMPUESTO DE RENTA____");
 Console.WriteLine("Su renta Anual es MENOR a 10.000$. Pagas Impuesdo del 5% ");
 Console.WriteLine("Su renta Anual es MAYOR a 10.000$ y MENOR a 20.000$. Pagas Impuesdo del 10% " );
 Console.WriteLine("Su renta Anual es MAYOR a 20.000$ y MENOR a 35.000$. Pagas Impuesdo del 15% ");
 Console.WriteLine("Su renta Anual es MAYOR a 35.000$ y MENOR a 45.000$. Pagas Impuesdo del 20% ");
 Console.WriteLine("Su renta Anual es MAYOR o Igual 45.000$. Pagas Impuesdo del 30% ");


Console.WriteLine("Ingrese  renta del primer semestre");
double RentaP = double.Parse (Console.ReadLine());
Console.WriteLine("Ingrese  su renta  segudno semestre");
double RentaS = double.Parse (Console.ReadLine());

RentaA = RentaP+ RentaS;

switch(RentaA){
    case < 10000:
        RentaTotal = RentaA * 0.5;
            Console.WriteLine("Debes pagar un impuesto del 5%:  Renta: " + RentaA +"$ + Impuesto: "+ RentaTotal + "$ Total a pagar = "+ (RentaA + RentaTotal)+ "$");
    break;

    case < 20000:
    RentaTotal = RentaA * 0.10;
        Console.WriteLine("Debes pagar un impuesto del 10%:  Renta: " + RentaA +"$ + Impuesto: "+ RentaTotal + "$ Total a pagar = "+ (RentaA + RentaTotal)+ "$");
    break;
    
    case < 35000:
        RentaTotal = RentaA * 0.15;
            Console.WriteLine("Debes pagar un inpuesto del 15%:  Renta: " + RentaA +"$ + Impuesto: "+ RentaTotal + "$ Total a pagar = "+ (RentaA + RentaTotal)+ "$");
    break;

    case < 45000:
        RentaTotal = RentaA * 0.20;
            Console.WriteLine("Debes pagar un inpuesto del 20%:  Renta: " + RentaA +"$ + Impuesto: "+ RentaTotal + "$ Total a pagar = "+ (RentaA + RentaTotal)+ "$");
    break;

    case >= 45000:
        RentaTotal = RentaA * 0.30;
            Console.WriteLine("Debes pagar un inpuesto del 30%:  Renta: " + RentaA +"$ + Impuesto: "+ RentaTotal + "$ Total a pagar = "+ (RentaA + RentaTotal)+ "$");
    break;
    
}



