using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptos.basicos
{
    public interface ITieneValor {

          decimal Valor {get;set;}
    }

    public class Cuenta:  ITieneValor {

        public string Codigo {get;set;}


        public string Propietario {get;set;}

        
        public decimal Valor {get;set;}

        public override string ToString(){

            return $"Codigo: {Codigo}. Valor {Valor}";
        }
        
    }


    public static class MatricesCurso
    {

        public static void EjercicioBasico() { 

            //Forma A)
            var listaNumeros = new int[] {1,3,4,5,3};

            var listaCadenas = new string[]{"Quito","Guayaquil","Cuenca"};

            //var listaLoca = new dynamic[]{"Quito",1,true};

            //Forma B)
            var listaNumerosSinInicializar = new int[3];

            listaNumerosSinInicializar[0] = 30;
            listaNumerosSinInicializar[1] = 45;
            listaNumerosSinInicializar[2] = 45;

            var listaObjectos = new ITieneValor[]{
                        new Cuenta(){Codigo="Cuenta1", Valor=20.3M },
                        new Cuenta(){Codigo="Cuenta2", Valor=10M},
                        new Cuenta(){Codigo="Cuenta3", Valor=492.3M}}; 


        }

        public static void EjercicioRecorrer() { 
            
            var listaObjectos = new Cuenta[]{
                        new Cuenta(){Codigo="Cuenta1", Valor=20.3M },
                        new Cuenta(){Codigo="Cuenta2", Valor=10M},
                        new Cuenta(){Codigo="Cuenta3", Valor=492.3M}}; 

            for (int i = 0; i < listaObjectos.Length; i++)
            {
                Console.WriteLine(listaObjectos[i]); 
            }

            foreach (var item in listaObjectos)
            {
                Console.WriteLine(item); 
            } 
            
        }

    }
}
