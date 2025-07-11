using System;

public class Persona
{
	//Atributos
	public int idPersona { get; set; }
	public string nombrePersona { get; set; }
    public string apellidoPersona { get; set; }
    public string tipoPersona { get; set; }
	public string direccionPersona { get; set; }
	public double contactoPersona { get; set; }

	//Constructor Vacio
	public Persona() { }
    //Constructor con parametros
    public Persona(int idPersona, string nombrePersona, string apellidoPersona, string tipoPersona, string direccionPersona, int contactoPersona) { 
		this.idPersona = idPersona;
		this.nombrePersona = nombrePersona;
		this.apellidoPersona = apellidoPersona;
		this.tipoPersona = tipoPersona;
		this.direccionPersona = direccionPersona;
		this.contactoPersona = contactoPersona;
	}

	//Metodos
	public virtual void mostrarInformacion() {
		Console.WriteLine($"Nombre y apellido: {nombrePersona}{apellidoPersona}, id: {idPersona}, tipodepersona: {tipoPersona}, direccion: {direccionPersona}, contacto: {contactoPersona}");
	}
}
