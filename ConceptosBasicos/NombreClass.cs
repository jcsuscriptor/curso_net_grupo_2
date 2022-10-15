using System;

namespace Curso
{
 
    //Public: Tipo Acceso
    public class NombreClase
    {
  
        //Datos
        //Propiedades. 
        public string Id { get; set; }
        public string Nombre { get; set; }
        
        public  int ReferenciaNumerica { get; private set; }

        public bool Activo { get; set; }


        private string _nombreVariable;

        public string NombreVariable
        {

            get
            {
                return _nombreVariable;
            }

            set
            {

                if (value == null)
                {
                    throw new Exception("no permite nulos");
                }

                _nombreVariable = value;

            }
        }



        //Comportamiento
        //Metodos
        public void NombreMetodo()
        {

            Console.WriteLine("Se ejecuto metodo");

        }

        public string Obtener(string codigo)
        {

            return $"El codigo {codigo}";

        }

    }

}
