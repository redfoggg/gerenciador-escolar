using System;

namespace gerenciador.escolar.Models;

/// <summary>
/// Classe que representa os professores. 
/// Professores ministram disciplinas e detem informações
/// sobre as diferentes disciplinas que ensinam bem como as turmas.
/// </summary>
public class Teacher : ModelBase<Guid>
{
    /// <summary>
    /// Construtor com somente o nome do(a) aluno(a). 
    /// </summary>
    /// <param name="name">Nome do(a) aluno(a)</param>
    /// <param name="teacherDisciplines">
    /// Um array do objeto Discipline representando
    /// as disciplinas que são minsitradas.
    /// </param>
    public Teacher(string name, Discipline[] teacherDisciplines) : base()
    {
        Name = name;
        TeacherDisciplines = teacherDisciplines;
    }
    
    /// <summary>
    /// Construtor com somente o nome do(a) professor(a). 
    /// </summary>
    /// <param name="name">Nome do(a) professor(a)</param>
    public Teacher(string name) : base()
    {
        Name = name;
        TeacherDisciplines = new Discipline[] { };
    }

    public string Name { get; }
    public Discipline[] TeacherDisciplines { get; }
}
