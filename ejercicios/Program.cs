//Ejercicio 1

//libro objlibro = new libro("A500PE","Divergente","Carlos Barrientos",200);

//Console.WriteLine("El codigo del libro es: {0}, el titulo es: {1}, el autor es: {2} y tiene {3} paginas",objlibro.CodLibro,objlibro.Titulo,objlibro.Autor,objlibro.NroPags);

//public class libro
//{
//    public string CodLibro { get; set; }
//    public string Titulo { get; set; }
//    public string Autor { get; set; }
//    public int NroPags { get; set; }

//    public libro()
//    {

//    }
//    public libro(string CodLibro, string titulo, string autor,int NroPags)
//    {
//        this.CodLibro = CodLibro;
//        this.Titulo = titulo;
//        this.Autor = autor;
//        this.NroPags = NroPags;
//    }

//}

//Ejercicio 2

//Empleado objempleado = new Empleado("V-29897144","Carlos","Alexander Barrientos","San Martin",04142200584);

//Empleado objempleado2 = new Empleado("v-14892507","Andres","Chala","Bello Monte", 04142200584);

//Console.WriteLine("La cedula del primer empleado es: {0}, Nombre del empleado: {1}, apellido del empleado: {2}, direccion: {3} y telefono {4} \n",
//                                                                                                 objempleado.cedula,
//                                                                                                 objempleado.Nombre,
//                                                                                                 objempleado.apellidos,
//                                                                                                 objempleado.direccion,
//                                                                                                 objempleado.telefono);



//Console.WriteLine("La cedula del segundo empleado es: {0}, Nombre del empleado: {1}, apellido del empleado: {2}, direccion: {3} y telefono {4} ",
//                                                                                                 objempleado2.cedula,
//                                                                                                 objempleado2.Nombre,
//                                                                                                 objempleado2.apellidos,
//                                                                                                 objempleado2.direccion,
//                                                                                                 objempleado2.telefono);

//public class Empleado
//{
//    public string cedula { get; set; }
//    public string Nombre { get; set; }
//    public string apellidos { get; set; }
//    public string direccion { get; set; }
//    public long telefono { get; set; }

//    public Empleado()
//    {

//    }

//    public Empleado(string cedula, string nombre, string apellidos, string direccion,long telefono)
//    {
//        this.cedula = cedula;
//        this.Nombre = nombre;
//        this.apellidos = apellidos;
//        this.direccion = direccion;
//        this.telefono = telefono;
//    }

//}

//Ejercicio 3

Estudiante objestudiante = new Estudiante("v-29897144","Juan","Marquez",'M',DateTime.Parse("21/08/2003"));

Estudiante objestudiante2 = new Estudiante("v-16673116", "Maria", "Vitale", 'F', DateTime.Parse("22/03/2003"));

Console.WriteLine("La cedula del primer estudiante es: {0}, Nombre: {1}, apellido: {2}, genero: {3},fecha de nacimiento {4} \n",
                                                                                                 objestudiante.cedula,
                                                                                                 objestudiante.nombre,
                                                                                                 objestudiante.apellidos,
                                                                                                 objestudiante.genero,
                                                                                                 objestudiante.fechaNacimiento);



Console.WriteLine("La cedula del primer estudiante es: {0}, Nombre: {1}, apellido: {2}, genero: {3},fecha de nacimiento {4} \n",
                                                                                                 objestudiante2.cedula,
                                                                                                 objestudiante2.nombre,
                                                                                                 objestudiante2.apellidos,
                                                                                                 objestudiante2.genero,
                                                                                                 objestudiante2.fechaNacimiento);

public class persona
{
    public string cedula { get; set; }
    public string nombre { get; set; }
    public string apellidos { get; set; }
    public char genero { get; set; }
    public DateTime fechaNacimientos { get; set; }

    public persona() { }

    public persona(string cedula, string nombre, string apellidos)
    {
        this.cedula = cedula;
        this.nombre = nombre;
        this.apellidos = apellidos;
    }

    
}

public class Estudiante : persona
{
    public char genero;
    public DateTime fechaNacimiento;

    public Estudiante(string cedula, string nombre, string apellidos, char genero, DateTime fechaNacimiento)
                      : base(cedula, nombre, apellidos)
    {
        this.genero = genero;
        this.fechaNacimiento = fechaNacimiento;
    }
}

