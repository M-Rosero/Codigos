using System;

public class Produccion : AreaEmpresas
{
    //Atributos
    public string lineaProduccion { get; set; }
    public int totalProduccion { get; set; }
    //ConstructorVacio
    public Produccion() { }
    //Constructor de parametros
    public Produccion(string lineaProduccion, int totalProduccion) {
        this.lineaProduccion = lineaProduccion;
        this.totalProduccion = totalProduccion;
    }

    //Metodos
    public override void mostrarAreas()
    {
        base.mostrarAreas();
        Console.WriteLine($"La linea de produccion es: {lineaProduccion} ,y el total de produccion es: {totalProduccion}  ");
    }

}
