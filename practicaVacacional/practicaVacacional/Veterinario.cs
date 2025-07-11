using System;

public class Veterinario:Persona
{
    public int numeroLicenciaprofesional { get; set; }
    public string especialidadMedica {  get; set; }

    public Veterinario() { }

    public Veterinario(int numeroLicenciaprofesional,string especialidadMedica) {
        this.numeroLicenciaprofesional=numeroLicenciaprofesional;
        this.especialidadMedica=especialidadMedica;
    }

    public override void mostrarInformacion() { 
        base.mostrarInformacion();
        Console.WriteLine($"numero de licencia veterinario: {numeroLicenciaprofesional} y es especialista en {especialidadMedica}");
    
    }

}
