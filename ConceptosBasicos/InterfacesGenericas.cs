

interface IOperacionGenerica <T> {

    T Calcular(T a,T b);

}

public class OperacionGenericaSumaInt : IOperacionGenerica<int>
{
    public int Calcular(int a, int b)
    {
        return a+b;
    }
}


public class OperacionGenericaSumaDouble : IOperacionGenerica<double>
{
    public double Calcular(double a, double b)
    {
        return a+b;
    }
} 


public class OperacionGenericaSumaLong : IOperacionGenerica<long>
{
    public long Calcular(long a, long b)
    {
        return a+b;
    }
}

public class OperacionGenericaSumaString : IOperacionGenerica<string>
{
    public string Calcular(string a, string b)
    {
        //Suma => Con
        //"Abc" + "123"
        //Abc123
        return a+b;
    }
} 