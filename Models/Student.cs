using System;
using System.Collections.Generic;

namespace gerenciador.escolar.Models;

public class Student : IdentificationBase<Guid>
{
    private HashSet<(Discipline, float?[])> grades;

    public Student(string name, HashSet<(Discipline, float?[])> grades) : base()
    {
        Name = name;
        this.grades = grades;
    }

    public Student(string name) : base()
    {
        Name = name;
        this.grades = new HashSet<(Discipline, float?[])>();
    }

    public string Name { get; }
    
    public HashSet<(Discipline, float?[])> Grades { get => grades; }

    public void AddGrade(Discipline discipline, float grade)
    {
        throw new NotImplementedException();
    }
}

