interface IProcesar {

    void Procesar();
}

interface ICalcular {

    void Calcular();
}

interface IObtener {

    void Obtener();
}

interface ICombinacion: ICalcular,IProcesar {

}

public abstract class AbstractProcesarCalcular : ICalcular
{
    public abstract void Calcular(); 
}

public abstract class AbstractValores {

    public string Nombre {get;set;}
}

public class ProcesarCalcular : AbstractProcesarCalcular, IObtener, ICombinacion
{
    public  void Procesar()
    {
        throw new NotImplementedException();
    }

    public override void Calcular(){
        throw new NotImplementedException();
    }

    public void Obtener()
    {
        throw new NotImplementedException();
    }
}