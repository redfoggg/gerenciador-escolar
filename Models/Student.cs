using System;
using System.Collections.Generic;

namespace gerenciador.escolar.Models;


/// <summary>
/// Classe que representa os alunos. 
/// Alunos cursam disciplinas e detem informações
/// sobre suas notas nas disciplinas matriculadas bem como
/// outros status necessários a vida escolar de um aluno.
/// </summary>
public class Student : ModelBase<Guid>
{
    private HashSet<(Discipline, float?[])> grades;

    /// <summary>
    /// Construtor com todas propriedades referentes a(o) aluno(a).
    /// </summary>
    /// <param name="name">Nome do(a) aluno(a)</param>
    /// <param name="grades">Um HashSet contendo o objeto disciplina e um array de notas do tipo float</param>
    public Student(string name, HashSet<(Discipline, float?[])> grades) : base()
    {
        Name = name;
        this.grades = grades;
    }

    /// <summary>
    /// Construtor com somente o nome do(a) aluno(a). 
    /// </summary>
    /// <param name="name">Nome do(a) aluno(a)</param>
    /// <param name="grades">Um HashSet contendo o objeto disciplina e um array de notas do tipo float</param>
    public Student(string name) : base()
    {
        Name = name;
        this.grades = new HashSet<(Discipline, float?[])>();
    }

    /// <summary>
    /// Propriedade que representa o nome do(a) aluno(a). 
    /// </summary>
    public string Name { get; }
    
    /// <summary>
    /// Propriedade que representa o nome do(a) aluno(a). 
    /// </summary>
    public HashSet<(Discipline, float?[])> Grades { get => grades; }

    /// <summary>
    /// Adiciona uma nota em uma determinada disciplina do(a) aluno(a). 
    /// TODO: Implementar método.
    /// </summary>
    /// <param name="discipline">Objeto disciplina</param>
    /// <param name="grade">Um float representandoa nota a ser adicionada</param>
    public void AddGrade(Discipline discipline, float grade)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Retorna se um aluno está ou não aprovado em determinada disciplina.
    /// TODO: Implementar método.
    /// </summary>
    /// <param name="discipline">Objeto disciplina</param>
    public bool IsApprovedInDisclipne(Discipline discipline)
    {
        throw new NotImplementedException();
    }
}

