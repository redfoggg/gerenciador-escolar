using System;
using System.Collections.Generic;

namespace gerenciador.escolar.Models;

public class Student : IdentificationBase<Guid>
{
    public Student(string name, HashSet<(Discipline, float[])> grades)
    {
        Name = name;
        Grades = grades;
    }

    public string Name { get; }
    public HashSet<(Discipline, float[])> Grades  { get; private set; }
}

