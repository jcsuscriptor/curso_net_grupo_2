

//Nombres de las interfaces.
//Simpre deben iniciar con la letra I
//Las interfaces no requieren establece el tipo de acceso. (Son publicas),
//se pueden establecer tipo internal


interface IOperacion {

     int Calcular(int valorA,int valorB);  

     double Calcular(double valorA,double valorB);      

     void Imprimir(int valorA,int valorB);
}
 


public abstract class AbstractOperacion  : IOperacion 
{
    public abstract int Calcular(int valorA, int valorB);

    public abstract double Calcular(double valorA, double valorB);

    public  void Imprimir(int valorA, int valorB){
        
        Console.WriteLine($"Valor A: {valorA}. Valor B: {valorB}"); 
        //Console.WriteLine(string.Format("Valor A: {0}. Valor B: {1}",valorA,valorB);
    }
}

public class OperacionSuma : AbstractOperacion
{
    public override int Calcular(int valorA, int valorB)
    {
        return valorA + valorB;
    }

    public override double Calcular(double valorA, double valorB)
    {
        return valorA + valorB;
    } 
}

public class OperacionResta : AbstractOperacion
{
    public override int Calcular(int valorA, int valorB)
    {
        return valorA - valorB;
    }

    public override double Calcular(double valorA, double valorB)
    {
        return valorA - valorB;
    }
}