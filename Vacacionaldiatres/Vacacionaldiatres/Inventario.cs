using System;
using System.Reflection.Metadata.Ecma335;

public class Inventario : AreaEmpresas
{
	//Atributos
	public int totalStock { get; set; }
    public DateTime fechaInventario { get; set; }
    public string ubicacionStock { get; set; }

    //Constructor Vacio
    public Inventario() { }
	//Contructor con parametros
	public Inventario(int totalStock, DateTime fechaInventario, string ubicacionStock) {
		this.totalStock = totalStock;
		this.fechaInventario = fechaInventario;
		this.ubicacionStock = ubicacionStock;

	}
	//Metodos
	public override void mostrarAreas(){
		base.mostrarAreas();
		Console.WriteLine($"El total del stock es: {totalStock}, la fecha del inventario es: {fechaInventario: dd/MM/yyyy} y su ubicacion es: {ubicacionStock}");

	}
}
