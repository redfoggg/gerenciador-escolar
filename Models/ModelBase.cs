using System;

namespace gerenciador.escolar.Models;

/// <summary>
/// Classe base para as models da aplicação, onde fica as lógicas básicas
/// que devem estar presentes nas models dessa aplicação.
/// </summary>
public class ModelBase<T>
{
    /// <summary>
    /// Construtor responsável por instanciar um objeto com um Id do tipo Guid aleatório.
    /// </summary>
    public ModelBase()
    {
        Id = (T) Convert.ChangeType(Guid.NewGuid(), typeof(T));
    }
    
    /// <summary>
    /// Construtor responsável por instanciar um objeto com um Id do tipo string
    /// e não aleatório.
    /// </summary>
    /// <param name="id">Uma string representando o Id do objeto</param>
    public ModelBase(string id)
    {
        Id = (T) Convert.ChangeType(id, typeof(T));
    }

    /// <summary>
    /// Id do tipo generico para as models da aplicação.
    /// </summary>
    public T Id { get; }
}
