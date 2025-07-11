//Persona persona = new Persona(1,"Mauricio","Rosero","Gamarra","Programacion");
//persona.mostrarPersona();
//int id;
//string nombre, apellido, direccion,programa;
//Console.WriteLine("Ingresa el Id: ");
//id = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingresa el Nombre: ");
//nombre =Console.ReadLine();
//Console.WriteLine("Ingresa Apellido: ");
//apellido =Console.ReadLine();
//Console.WriteLine("Ingresa la direccion: ");
//direccion = Console.ReadLine();
//Console.WriteLine("programa al que pertenece: ");
//programa=Console.ReadLine();




//Persona persona1 = new Persona(id, nombre, apellido, direccion,programa);
string respuesta;
Console.WriteLine("¿ Es estudiante (si/no) : ?");
respuesta = Console.ReadLine().ToLower();
if (respuesta == "si")
{
    Estudiante estudiante = new Estudiante();
    Console.WriteLine("Si es un estudiante");
    
    
    
    Console.WriteLine("Ingresa el Id: ");
    estudiante.idPersona = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa el Nombre: ");
    estudiante.nombre = Console.ReadLine();
    Console.WriteLine("Ingresa Apellido: ");
    estudiante.apellidoPersona = Console.ReadLine();
    Console.WriteLine("Ingresa la direccion: ");
    estudiante.direccionPersona = Console.ReadLine();
    Console.WriteLine("programa al que pertenece: ");
    estudiante.programaPersona = Console.ReadLine();
    Console.WriteLine("Activo o inactivo: ");
    estudiante.matriculaEstudiante = Console.ReadLine();
    Console.WriteLine("promedio: ");
    estudiante.promedioEstudiante = float.Parse(Console.ReadLine());



   

    estudiante.mostrarPersona();
}
else {
    Console.WriteLine("No es un estudiante");
}
//persona1.mostrarPersona();



