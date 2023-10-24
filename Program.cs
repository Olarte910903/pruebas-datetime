int opcion;
TiempoCarro tiempos = new TiempoCarro();

Console.WriteLine("ingrese el primer tiempo");
opcion = int.Parse(Console.ReadLine());


if(opcion == 1){
    tiempos.tiempo1 = DateTime.Now;
    
    Console.WriteLine("ingrese el segundo tiempo");
    opcion = int.Parse(Console.ReadLine());

    if(opcion == 2){
        tiempos.tiempo2 = DateTime.Now;

        tiempos.CalcularTiempo();
    }
}