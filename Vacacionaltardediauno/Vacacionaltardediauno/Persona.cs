using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Persona 
{
	//Atributos
	public int idPersona { get; set; }
	public string nombre { get; set; }
	public string apellidoPersona { get; set; }
	public string direccionPersona{ get; set; }
	public string programaPersona {get; set; }

	//Constructor

	public Persona(int idPersona, string nombre, string apellidoPersona, string direccionPersona, string programaPersona) { 
		this.idPersona = idPersona;
		this.nombre = nombre;	
		this.apellidoPersona = apellidoPersona;
		this.direccionPersona = direccionPersona;
		this.programaPersona = programaPersona;


	}

	//constructor paràmetros (Vacio)

	public Persona() {
	}

	//Metodos
	public virtual void mostrarPersona() {

		Console.WriteLine($"Los datos de la persona son: ID {idPersona}, nombres y apellidos {nombre} {apellidoPersona}, y su direccion es {direccionPersona}, el programa del estudiante es: {programaPersona}");

	


	}


}
