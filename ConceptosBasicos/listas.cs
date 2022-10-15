

public static class ListasCurso {

        public static void EjercicioBasico() { 
            
            //Agregar elementos
            var listaNumeros = new List<int>();

            listaNumeros.Add(10);
            listaNumeros.Add(23);
            listaNumeros.Add(43);
            listaNumeros.Add(-20);
            listaNumeros.Add(-20);

            Console.WriteLine("Todos");
            Imprimir(listaNumeros);

            //Eliminar elementos
            Console.WriteLine("Eliminar primero");
            listaNumeros.RemoveAt(0);
            Imprimir(listaNumeros);

            Console.WriteLine("Eliminar un elemento especifico");
            listaNumeros.Remove(-20);
            Imprimir(listaNumeros);

             Console.WriteLine("Reemplazar un valor");
            //Reemplazar un elemento
            listaNumeros[0] = listaNumeros[0]*10;
            Imprimir(listaNumeros); 
        }

        public static void Imprimir(List<int> datos) { 

            foreach (var item in datos)
            {
                Console.WriteLine(item);
            }

        }

}

public static class DireccionariosCurso {

        public static void EjercicioBasico() { 
            
            var listaPersonas = new Dictionary<string,Persona>();
            var listaCodigos = new Dictionary<string,string>();


            listaPersonas.Add("123",new Persona(){Identificacion="123",Nombre="Maria"});
            listaPersonas.Add("ABC",new Persona(){Identificacion="ABC",Nombre="Roberto"});
            listaPersonas.Add("XXL",new Persona(){Identificacion="XXL",Nombre="Antonio"});
 
            var resulta = listaPersonas.ContainsKey("123");

            var personaBuscada = listaPersonas["ABC"];

            foreach (var elemento in listaPersonas)
            {
                Console.WriteLine($"Key:{elemento.Key}, persona {elemento.Value}");
            }

            foreach (var elemento in listaCodigos)
            {
                Console.WriteLine($"Key:{elemento.Key}, persona {elemento.Value}");
            }


            var abc = new Persona<string,string>();
            abc.Id = "123";
 
            var abcGuid = new Persona<Guid,string>();
            abcGuid.Id = Guid.NewGuid();

            var abcLong = new Persona<long,string>();
            abcLong.Id = 123;


           

        }

 

}


public class Empleado {

    public string Identificacion {get;set;}

    public string Nombre {get;set;}

    public string Direccion {get;set;}
 
}


public class Persona<T,U> {

    public T Id {get;set;}

    public U Codigo {get;set;}

    public string Nombre {get;set;}
}

