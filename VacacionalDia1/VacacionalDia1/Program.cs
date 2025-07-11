
/*Resumen clase de la mañana 
 1. Comentarios
 2. Console.write()
 3. Console.writeline()
 4. Consolo.ReadLine()
 5. Concatenacion string, secuencias de escape
 */
String nombre, direccion,apellido;
Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido: ");
apellido = Console.ReadLine();
Console.WriteLine("Digite su direccion: ");
direccion = Console.ReadLine();
Console.WriteLine($"Bienvenido: {nombre} {apellido} Tu direccion es :  {direccion}");
