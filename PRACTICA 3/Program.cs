using PRACTICA_3;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    public static ArrayList AlumnosInscriptos = new ArrayList();
    public static ArrayList EscuelasConAlumnos = new ArrayList();
    


    public static void Main(string[] args)
    {
        
        char opcion;
        

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine(" A : Inscribir un alumno");
            Console.WriteLine(" B : Borrar un alumno");
            Console.WriteLine(" C : Indicar total de alumnos inscriptos ");
            Console.WriteLine(" D : Indicar escuelas que al menos tienen un alumno inscripto");
            Console.WriteLine(" E : Imprimir el listado de las escuelas, ordenado alfabeticamente ");

            Console.WriteLine("seleccione una opción o presione X para salir...");

            opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();


            switch (opcion)
            {
                case 'a':
                    Console.Clear();
                    InscribirAlumno();
                    break;
                case 'b':
                    Console.Clear();
                    BorrarAlumno();
                    break;
                case 'c':
                    Console.Clear();
                    Console.WriteLine($"el total de alumnos inscriptos es {AlumnosInscriptos.Count}");
                    break;
                case 'd':
                    Console.Clear();
                    Console.WriteLine($"el total de escuelas con alumnos inscriptos: {EscuelasConAlumnos.Count}");
                    break;
                case 'e':
                    Console.Clear();
                    ListarEscuelasOrdenadas();
                    break;
                case 'x':
                    Console.Clear();
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("opcion no valida. Por favor, selecciona una opción valida.");
                    break;
            }

        } while (opcion != 'x');
  

    }

    public static void InscribirAlumno()
    {
        Console.WriteLine("ingrese el DNI del alumno: ");
        int dni = int.Parse(Console.ReadLine());

        Console.WriteLine("ingrese el nombre del alumno: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("ingrese el apellido del alumno: ");
        string apellido = Console.ReadLine();

        Console.WriteLine("ingrese la escuela del alumno: ");
        string escuela = Console.ReadLine();

        Alumno nuevoAlumno = new Alumno(dni, nombre, apellido, escuela);

        AlumnosInscriptos.Add(nuevoAlumno);
        EscuelasConAlumnos.Add(escuela);

    }

    public static void BorrarAlumno()
    {

        Console.WriteLine("ingrese el DNI del alumno a borrar: ");
        int dniAlumnoBorrar = int.Parse(Console.ReadLine());

        for (int i = 0; i < AlumnosInscriptos.Count; i++)
        {
            Alumno aux = (Alumno) AlumnosInscriptos[i];

            if (aux.getDNI() ==  dniAlumnoBorrar)
            {
                AlumnosInscriptos.Remove(aux);
                Console.WriteLine($"alumno eliminado de la lista con dni {aux.getDNI()}");
            }


           
        }

        Console.WriteLine(AlumnosInscriptos);
    

    }

    static void ListarEscuelasOrdenadas()
    {
        Console.WriteLine("La lista de escuelas ordenadas son: ");
        Console.WriteLine("");
        for (int i = 0; i < EscuelasConAlumnos.Count; i++)
        {

            Console.WriteLine(EscuelasConAlumnos[i] );
         
        }
    }



}