using System;

namespace gerenciador.escolar.Models;

/// <summary>
/// Classe que representa as disciplinas.
/// Disciplinas são ministradas por professores
/// e cursadas por alunos.
/// </summary>
public class Discipline : ModelBase<string>
{

    /// <summary>
    /// Construtor com todas propriedades referentes a disciplina. 
    /// </summary>
    /// <param name="name">Nome da disciplina</param>
    /// <param name="topics">Array com todos tópicos da disciplina</param>
    /// <param name="classroom">Turma da disciplina</param>
    /// <param name="id">Identificador da disciplina</param>
    public Discipline(string name, string[] topics, string classroom, string id) : base(id)
    {
        Name = name;
        Topics = topics;
        Classroom = classroom;
    }
    
    /// <summary>
    /// Construtor com somente o nome e o identificador da disciplina. 
    /// </summary>
    /// <param name="name">Nome da disciplina</param>
    /// <param name="id">Identificador da disciplina</param>
    public Discipline(string name, string id) : base(id)
    {
        Name = name;
        Topics = Array.Empty<string>();
        Classroom = "";
    }
   
    /// <summary>
    /// Propriedade que representa o nome da disciplina. 
    /// </summary>
    public string Name { get; }
   
    /// <summary>
    /// Propriedade que representa os tópicos da disciplina em um array de strings. 
    /// </summary>
    public string[] Topics { get; }
    
    /// <summary>
    /// Propriedade que representa a turma. 
    /// </summary>
    public string Classroom { get; }
}

