using System;

public class Mercadeo
{
	//Atributos
	public string lineaMercadeo { get; set; }
	public int totalMercadeo { get; set; }
	//Contructor Vacio
	public Mercadeo() { }
	//Contructor Con parametros
	public Mercadeo(string lineaMercadeo,int totalMercadeo) {
	this.lineaMercadeo = lineaMercadeo;
	this.totalMercadeo = totalMercadeo;
	}
    //Metodo polimorfico
  //  public override void mostrarAreas()
  //  {
  //      base.mostrarAreas();
		//Console.WriteLine($"La linea de mercado es: {lineaMercadeo}, y el total de mercado es: {totalMercadeo}");
  //  }

}
