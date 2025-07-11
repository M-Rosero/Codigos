using System;

public class Animal
{
	public string nombreAnimal { get; set; }
	public string especieAnimal { get; set; }
	public string razaAnimal { get; set; }
	public int edadAnimal { get; set; }

	public Animal() { }

    public Animal(string nombreAnimal,string especieAnimal, string razaAnimal, int edadAnimal) {
		this.nombreAnimal = nombreAnimal;
		this.especieAnimal = especieAnimal;
		this.razaAnimal = razaAnimal;
		this.edadAnimal = edadAnimal;
	}

	public void mostrarInformacion() { }
}
