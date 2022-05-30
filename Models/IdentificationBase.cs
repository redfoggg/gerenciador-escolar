using System;

namespace gerenciador.escolar.Models;

public class IdentificationBase<T>
{
    public IdentificationBase()
    {
        Id = (T) Convert.ChangeType(Guid.NewGuid(), typeof(T));
    }
    
    public IdentificationBase(string id)
    {
        Id = (T) Convert.ChangeType(id, typeof(T));
    }

    public T Id { get; }
}
