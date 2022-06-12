/*
Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta
la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera 
con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
*/

using Billetes.Modelo;

// cargo cantidad de billetes x billetera
var billetera1 = new Billetera(10,5,2,1,1,1,2);
var billetera2 = new Billetera(10, 5, 2, 1, 1, 1, 4);



Console.WriteLine("El importe total de la billetera es: " +
    billetera1.Total(billetera1.BilletesDe10,
                   billetera1.BilletesDe20,
                   billetera1.BilletesDe50,
                   billetera1.BilletesDe100,
                   billetera1.BilletesDe200,
                   billetera1.BilletesDe500,
                   billetera1.BilletesDe1000));


Billetera b3 = billetera1.Combinar(billetera2);

// para corroborar cantidad de billetes
Console.WriteLine($"La suma de dinero en billetes de 10 es ${b3.BilletesDe10} de 20 ${b3.BilletesDe20} de 50 ${b3.BilletesDe50}" +
    $"de 100 ${b3.BilletesDe100} de 500 ${b3.BilletesDe500} de 1000 $ {b3.BilletesDe1000}"); 

// llamo método para vaciar billeteras
billetera1.BilleteraAVaciar(billetera1);
billetera2.BilleteraAVaciar(billetera2);

Console.WriteLine();
// para corroborar billetera vacía
Console.WriteLine($"la cantidad de billetes de 10 de la billetera 1 después de borrada es: {billetera1.BilletesDe10}");
Console.WriteLine($"la cantidad de billetes de 20 de la billetera 2 después de borrada es: {billetera2.BilletesDe20} etc etc");