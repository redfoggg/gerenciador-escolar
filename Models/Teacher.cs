using System;

namespace gerenciador.escolar.Models;

public class Teacher : IdentificationBase<Guid>
{
    public Teacher(string name, Discipline[] teacherDisciplines)
    {
        Name = name;
        TeacherDisciplines = teacherDisciplines;
    }
    public string Name { get; }
    public Discipline[] TeacherDisciplines { get; }
}
