using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "jperez";
            estudiante.Password = "123456";
            estudiante.Nombre = "Juan";
            estudiante.Matricula = "56789A";

            estudiante.login("jperez", "123456");
            estudiante.login();

            Conserje conserje = new Conserje();
            conserje.Nombre = "JUAN";
            conserje.Sueldo = 2500;
            conserje.Horas = 8;

            //Listas en ves de Arrays en .Net C#
            List<Docente> listaDocentes = new List<Docente>();
            listaDocentes.Add(new Docente() {
                Cuenta= "smamani",
                Password = "12477",
                Nombre = "Saul",
                Sueldo = 1234,
                MateriaDicta = "Algebra",
                Celular = 65483145
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "sperez",
                Password = "12477",
                Nombre = "Ana",
                Sueldo = 123,
                MateriaDicta = "quimica",
                Celular = 65847912
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "scarla",
                Password = "12477",
                Nombre = "Carla",
                Sueldo = 12,
                MateriaDicta = "fisica 1",
                Celular = 32569866
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "lidia",
                Password = "12477",
                Nombre = "Lidia",
                Sueldo = 23,
                MateriaDicta = "calculo",
                Celular = 69587411
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "jOSE",
                Password = "12477",
                Nombre = "Jose",
                Sueldo = 12,
                MateriaDicta = "ecuaciones diferenciales",
                Celular = 65489722
            });

             listaDocentes.Add(new Docente()
            {
                Cuenta = "Lisa",
                Password = "12477",
                Nombre = "lisa",
                Sueldo = 23,
                 MateriaDicta = "progra 3",
                 Celular = 32165847
             });

             listaDocentes.Add(new Docente()
            {
                Cuenta = "Lidy",
                Password = "12477",
                Nombre = "lidi",
                Sueldo = 230,
                 MateriaDicta = "estructura de computadores",
                 Celular = 98745245
             });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "Pepe",
                Password = "12477",
                Nombre = "pepe",
                Sueldo = 54,
                MateriaDicta = "fluidos",
                Celular = 65481364
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "Rubenmm",
                Password = "65487",
                Nombre = "Ruben",
                Sueldo = 5400,
                MateriaDicta = "dibujo",
                Celular = 67252550
            });

            listaDocentes.Add(new Docente()
            {
                Cuenta = "guzmanhC",
                Password = "9875645",
                Nombre = "Cesar",
                Sueldo = 7800,
                MateriaDicta = "transformadas",
                Celular = 71103741
            });
            MostrarLista(listaDocentes);

            Double promedio = getPromedio(listaDocentes);
            Console.WriteLine("\n--- Promedio: {0}", promedio.ToString("##.##"));

            double promedio2 = getPromedioDos(listaDocentes);
            Console.WriteLine("\n--- Promedio Dos: {0}", promedio2.ToString("##.##"));

            double promedio3 = getPromedioTres(listaDocentes);
            Console.WriteLine("\n--- Promedio Tres: {0}", promedio3.ToString("##.##"));

            double promedio4 = getPromedioCuatro(listaDocentes);
            Console.WriteLine("\n--- Promedio Cuatro Modificado: {0}", promedio4.ToString("##.##"));


            Console.ReadKey(); 
        }

        private static double getPromedioCuatro(List<Docente> listaDocentes)
        {
            //consuntas LINQ
            decimal prom = (
                
                from item in listaDocentes
                where item.Sueldo < 200
                select item.Sueldo
                
                ).Average();
            return (double)prom;
        }

        private static double getPromedioTres(List<Docente> listaDocentes)
        {
            //funciones Lambda
            decimal sum = listaDocentes.Sum(x => x.Sueldo);
            int total = listaDocentes.Count;
            return (double)(sum / total);
        }

        private static double getPromedioDos(List<Docente> listaDocentes)
        {
            //Funcones lamda
            decimal promedio = listaDocentes.Average(x => x.Sueldo);
            return (double)promedio;
        }

        private static double getPromedio(List<Docente> listaDocentes)
        {
            Decimal sum = 0;
            foreach (Docente item in listaDocentes) {
                sum += item.Sueldo;
            }

            return (double)(sum / listaDocentes.Count()); //CAST
        }

        private static void MostrarLista(List<Docente> listaDocentes)
        {
            Console.WriteLine("\n------- LISTA DE DOCENTES y OTROSS --------\n");

            foreach (Docente item in listaDocentes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
