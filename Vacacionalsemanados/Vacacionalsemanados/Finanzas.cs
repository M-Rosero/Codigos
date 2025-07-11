using System;

public class Finanzas:AreaEmpresas
{
	//Atributos
	public double ingresosFinancieros { get; set; }
	public double egresosFinancieros { get; set; }
	public double utilidadNeta { get; set;}
	public DateTime fechaFinanza { get; set; }
	//contructor Vacio
	public Finanzas() { }
    //constructor de atributos
    public Finanzas(double ingresosFinancieros, double egresosFinancieros, double utilidadNeta, DateTime fechaFinanza) {
	this.ingresosFinancieros = ingresosFinancieros;
	this.egresosFinancieros=egresosFinancieros;
	this.utilidadNeta = utilidadNeta;
	this.fechaFinanza = fechaFinanza;
	}
	//metodo polimorfico
	public override void mostrarAreas() { 
		base.mostrarAreas();
		Console.WriteLine($"fecha finanzas: {fechaFinanza:dd/MM/yyyy}");
		Console.WriteLine($"los ingresos a la fecha son: {ingresosFinancieros}");
		Console.WriteLine($"los egresos a la fecha son: {egresosFinancieros}");
		Console.WriteLine($"la utilidad neta a la fecha es: {utilidadNeta}");
	}
    public override void informeFinanciero()
    {
        base.informeFinanciero();
    }

    public override void reporteFinanciero()
    {
        base.reporteFinanciero();
    }



}
