class TiempoCarro{
    public DateTime tiempo1 {get; set;}
    public DateTime tiempo2 {get; set;}

    TimeSpan tiempo3 {get; set;}

    public void CalcularTiempo(){
        tiempo3 = tiempo2 - tiempo1;
        Console.WriteLine($"Tiempo transcurrido: {tiempo3.TotalSeconds}");
    }
}