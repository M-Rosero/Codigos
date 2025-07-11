using System;

public class AreaEmpresas
{
	//Atributos
	public int idArea { get; set; }
	public string nombreArea { get; set; }
	public string responsableArea { get; set; }

	//Constructor Vacio
	public AreaEmpresas() {
	}
	//Constructor de atributos
	public AreaEmpresas(int idArea, string nombreArea, string responsableArea) {
		this.idArea = idArea;
		this.nombreArea = nombreArea;
		this.responsableArea = responsableArea;
	}
	//Metodos 
	public virtual void mostrarAreas() {
		Console.WriteLine($"El id del area {nombreArea} es: {idArea} y el responsable es: {responsableArea}");
	}
	public virtual void reporteFinanciero() {
		Console.WriteLine($"El siguiente es el reporte financiero:  ");


	}
	public virtual void informeFinanciero() {
		Console.WriteLine($"Este es el informe financiero: ");


	}
}