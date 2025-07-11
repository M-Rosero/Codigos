using System;

public class Estudiante : Persona
{
    public string matriculaEstudiante { get; set; }
    public float promedioEstudiante { get; set; }
    public Estudiante (string matriculaEstudiante, float promedioEstudiante)
    {
        this.matriculaEstudiante = matriculaEstudiante;
        this.promedioEstudiante = promedioEstudiante;
    }
    public Estudiante() { 
    
    }
    //Metodo con polimorfismo
    public override void mostrarPersona()
    {
        base.mostrarPersona();
        Console.WriteLine($" La Matricula es:  {matriculaEstudiante} y el promedio es: {promedioEstudiante:F1}");
    }

}
