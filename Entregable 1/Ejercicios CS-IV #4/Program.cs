// En una empresa, los empleados son premiados al final de cada año por su rendimiento. 
// Los puntos que pueden tener en la evaluación son: 0.0, 0.4 y 0.6. pero no pueden tener valores intermedios entre las cifras mencionadas. 
// A continuación se muestra una tabla con los niveles correspondientes a cada puntuación. 
// La bonificación de dinero de cada nivel es de 50000$ multiplicada por la puntuación del nivel. Al final del programa se debe imprimir el nivel de evaluación y 
// la bonificación ganada.


Console.WriteLine("Ingrese la calificación del empleado (0,0  0,4  0,6) ingrese el decima con (,)");
float cali=float.Parse(Console.ReadLine());
 switch (cali)
    {
         case  0.0F:
             Console.WriteLine("El nivel de evaluación es Inaceptable y su bonificación es "+50000*0.0);
             break;
        case  0.4F:
             Console.WriteLine("El nivel de evaluación es Aceptable y su bonificación es "+50000*0.4);
             break;
        case  0.6F:
             Console.WriteLine("El nivel de evaluación es Meritorio y su bonificación es "+50000*0.6);
             break;
         default:
            Console.WriteLine("Ingrese una evaluación valida (0,0  0,4  0,6) ");
            break;
    }