// 3) Una pizzería llamada Pizzas el Fercho tiene pizzas vegetarianas y no vegetarianas. Los ingredientes para cada una de las pizzas aparecen a continuación.

// Ingredientes pizza vegetariana: Pimiento y champiñones.
// Ingredientes pizza no vegetarianos: Pepperoni, Salami y Pollo.

// Codificar un programa que solicite al usuario qué tipo de pizza desea, 
// y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija uno de ellos, 
// además todas las pizzas llevan mozzarella y tomate. Al final se debe mostrar por pantalla si la pizza es vegetariana o no y todos los ingredientes que lleva.

Console.WriteLine("Bienvenido a pizzas el Fercho. ¿Qué pizza desea?");
String TipoPizza=Console.ReadLine().ToLower();
if(TipoPizza!="vegetariana" & TipoPizza!="no vegetariana"){
Console.WriteLine("Seleccione un tipo de pizza valido (vegetariana o no vegetariana)");
Environment.Exit(0);
}
switch (TipoPizza) {
case "vegetariana":
Console.WriteLine("Los ingredientes son: Pimiento y champiñones ");
String ingredientesV=Console.ReadLine().ToLower();
    if(ingredientesV!="pimiento" & ingredientesV!="champiñones"){
        Console.WriteLine("Ingrese un ingrediente valido (Pimiento y champiñones)");
        Environment.Exit(0);
    }
    if(ingredientesV=="pimiento"){
        Console.WriteLine("Su pizza es vegetariana. Los ingredientes son: mozarella, tomate y pimiento");
    }
    if(ingredientesV=="champiñones"){
        Console.WriteLine("Su pizza es vegetariana. Los ingredientes son: mozarella, tomate y champiñones");
    }
    break;
case "no vegetariana":
Console.WriteLine("Los ingredientes son: Pepperoni, Salami y Pollo ");
String ingredientesC=Console.ReadLine().ToLower();
    if(ingredientesC!="pepperoni" & ingredientesC!="salami" & ingredientesC!="pollo"){
        Console.WriteLine("Ingrese un ingrediente valido (Pepperoni, Salami y Pollo)");
        Environment.Exit(0);
    }
    if(ingredientesC=="pepperoni"){
        Console.WriteLine("Su pizza no es vegetariana. Los ingredientes son: mozarella, tomate y pepperoni");
    }
    if(ingredientesC=="salami"){
        Console.WriteLine("Su pizza no es vegetariana. Los ingredientes son: mozarella, tomate y salami");
    }
    if(ingredientesC=="pollo"){
        Console.WriteLine("Su pizza no es vegetariana. Los ingredientes son: mozarella, tomate y pollo");
    }
    break;
default:;
    break;
};