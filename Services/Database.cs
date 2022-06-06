using System.Collections.Generic;
using gerenciador.escolar.Models;

namespace gerenciador.escolar.Services;

public class Database
{

    private List<Student> students;
    private List<Teacher> teachers;
    private List<Discipline> disciplines;

    public Database()
    {
        if(students is null)
            students = new List<Student>
                {
                    new Student("Jordan", 
                            new HashSet<(Discipline, float?[])> { (
                                new Discipline("Calculo C", new string[] {"Séries de Fourrier", "EDO 1 ordem", "EDO 2 ordem"}, "MATA04", "T1"), 
                                new float?[] { 3.2f, 5.0f, 10 })}),
                    new Student("Maria", 
                            new HashSet<(Discipline, float?[])> { (
                                new Discipline("Calculo C", new string[] {"Séries de Fourrier", "EDO 1 ordem", "EDO 2 ordem"}, "MATA04", "T2"), 
                                new float?[] { 7.2f, 9f, 10f })})
                };
    }

    public IEnumerable<Student> GetStudents() => students;

    public void AddStudent(Student student) => students.Add(student);
}
