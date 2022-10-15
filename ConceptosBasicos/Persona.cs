



public abstract class AbstractRepositorio {

    public abstract bool Save();

    public virtual bool Allow(){
        return true;
    }
}



public class RepositorioSqlServer : AbstractRepositorio
{
    public override bool Save()
    {
        throw new NotImplementedException();
    }
}


public class RepositorioOracle : AbstractRepositorio
{
    public override bool Save()
    {
        throw new NotImplementedException();
    }
}



//Contrato. ()
public abstract class Ente {

    public virtual string Nombre {get;set;}

    public abstract bool EsPersona();

}

public class Organizacion : Ente
{
    public override bool EsPersona()
    {
        throw new NotImplementedException();
    }
}

public class Persona: Ente {

   

    public string Identificacion {get;set;}

    protected virtual string RegistroUnico {get;set;}

    public override bool EsPersona()
    {
        throw new NotImplementedException();
    }

    public virtual bool RegistrarIngreso(){
           return false;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}. Identificacion {Identificacion}";
    }

}

public class Estudiante:Persona {

    public List<string> Cursos {get;set;}

    public override string Nombre { get => $"Est:{base.Nombre}"; set => base.Nombre = value; }
 
    public override string ToString()
    {
        return $"Nombre: {Nombre}. Identificacion {Identificacion}. Cursos: {string.Join(",",Cursos)}";


    }

    public Estudiante(){
        Cursos = new List<string>();
        this.RegistroUnico = "Estudiante";

        this.Nombre = "Estudiante.Foo";
    }
}

public class Profesor:Persona {

    public List<string> Materias {get;set;} = new List<string>();

    public override string Nombre { get => $"Pro:{base.Nombre}"; set => base.Nombre = value; }

    public override bool RegistrarIngreso(){
        return true;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}. Identificacion {Identificacion}. Materias: {string.Join(",",Materias)}";
    }

    public Profesor(){ 
        this.RegistroUnico = "Profesor";
    }
}
