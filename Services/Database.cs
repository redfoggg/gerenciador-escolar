using System.Collections.Generic;
using gerenciador.escolar.Models;

namespace gerenciador.escolar.Services;

/// <summary>
/// Classe responsável por simular um banco de dados, funciona salvando os dados na memória disponível 
/// para a aplicação
/// </summary>
public class Database
{

    private List<Student> students;
    private List<Teacher> teachers;
    private List<Discipline> disciplines;

    /// <summary>
    /// Construtor da classe Database, aqui são iniciados alguns valores nos campos presentes na classe
    /// de modo a simular um banco de dados previamente populado com algumas informações.
    /// </summary>
    public Database()
    {
        if(disciplines is null)
            disciplines = new List<Discipline>
                {
                    new Discipline("Calculo A", new string[] {"Limites", "Derivadas", "Integrais"}, "T1", "MATA01"),
                    new Discipline("Calculo C", new string[] {"Séries de Fourrier", "EDO 1 ordem", "EDO 2 ordem"}, "T1", "MATA04")
                };

        if(students is null)
            students = new List<Student>
                {
                    new Student("Aluna1", 
                            new HashSet<(Discipline, float?[])> { (
                                new Discipline("Calculo C", new string[] {"Séries de Fourrier", "EDO 1 ordem", "EDO 2 ordem"}, "MATA04", "T5"), 
                                new float?[] { 3.2f, 5.0f, 10 })}),
                    new Student("Aluna2", 
                            new HashSet<(Discipline, float?[])> { (
                                new Discipline("Calculo C", new string[] {"Séries de Fourrier", "EDO 1 ordem", "EDO 2 ordem"}, "MATA04", "T5"), 
                                new float?[] { 7.2f, 9f, 10f })})
                };

        if(teachers is null)
            teachers = new List<Teacher>
                {
                    new Teacher("Professora1", 
                            new Discipline[] { 
                                new Discipline("Calculo A", new string[] {"Limites", "Derivadas", "Integrais"}, "MATA01", "T1")}),
                    new Teacher("Professora2", 
                            new Discipline[] { 
                                new Discipline("Calculo C", new string[] {"Séries de Fourrier", "EDO 1 ordem", "EDO 2 ordem"}, "MATA04", "T1")})
                };
    }
    
    /// <summary>
    /// Retorna uma coleção dos alunos(a) salvas no banco em memória da aplicação. 
    /// para a aplicação
    /// </summary>
    public IEnumerable<Student> GetStudents() => students;
    
    /// <summary>
    /// Retorna uma coleção dos professores(a) salvas no banco em memória da aplicação. 
    /// </summary>
    public IEnumerable<Teacher> GetTeachers() => teachers;
    
    /// <summary>
    /// Retorna uma coleção das disciplinas salvas no banco em memória da aplicação. 
    /// </summary>
    public IEnumerable<Discipline> GetDisciplines() => disciplines;

    /// <summary>
    /// Adiciona um aluno(a) ao banco em memória da aplicação.
    /// </summary>
    /// <param name="discipline">Uma model representando o objeto aluno(a) a ser adicionado</param>
    public void AddStudent(Student student) => students.Add(student);
    
    /// <summary>
    /// Adiciona um professor(a) ao banco em memória da aplicação.
    /// </summary>
    /// <param name="discipline">Uma model representando o objeto professor(a) a ser adicionado</param>
    public void AddTeacher(Teacher teacher) => teachers.Add(teacher);
    
    /// <summary>
    /// Adiciona uma disciplina ao banco em memória da aplicação.
    /// </summary>
    /// <param name="discipline">Uma model representando o objeto disciplina a ser adicionado</param>
    public void AddDiscipline(Discipline discipline) => disciplines.Add(discipline);
}
