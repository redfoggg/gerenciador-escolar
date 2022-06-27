using System.Reactive.Linq;
using gerenciador.escolar.Models;
using gerenciador.escolar.Services;
using System;
using ReactiveUI;
using System.Linq;
using System.Collections.ObjectModel;

namespace gerenciador.escolar.ViewModels;


/// <summary>
/// Classe responsável pelo comportamento da tela principal, ela controla as rotas entre as telas.
/// TODO: Modificar o sistema de rotas tornando esta classe menos responsável e respeitando os 
/// limites do que uma classe deve fazer.
/// </summary>
public class MainWindowViewModel : ReactiveObject
{
    ReactiveObject content;
    private Database db;

    /// <summary>
    /// Construtor da tela controlodora.
    /// </summary>
    /// <param name="db">Objeto de acesso aos banco de dados</param>
    public MainWindowViewModel(Database db)
    {
        this.db = db;
        content = new MenuWindowViewModel();
        Students = new StudentListViewModel(Enumerable.Empty<Student>());
        Teachers = new TeacherListViewModel(Enumerable.Empty<Teacher>());
        Disciplines = new DisciplineListViewModel(Enumerable.Empty<Discipline>());
    }

    /// <summary>
    /// Propriedade que representa o conteúdo mostrado, esta é utilizada
    /// para variar o conteúdo da tela dependendo de qual método é chamado
    /// e sua classe ReactiveObject permite através da polimorfia o uso de outras
    /// classes que derivem da mesma. 
    /// </summary>
    public ReactiveObject Content 
    {
        get => content;
        private set => this.RaiseAndSetIfChanged(ref content, value);
    }

    /// <summary>
    /// Propriedade que representa a model da listagem de estudantes.
    /// </summary>
    public StudentListViewModel Students { get; }
    
    /// <summary>
    /// Propriedade que representa a model da listagem de professores(as).
    /// </summary>
    public TeacherListViewModel Teachers { get; } 
    
    /// <summary>
    /// Propriedade que representa a model da listagem de disciplinas.
    /// </summary>
    public DisciplineListViewModel Disciplines { get; } 

    /// <summary>
    /// Método responsável por adicionar alunos(as) ao sistema ao clicar no botão "Add Student".
    /// </summary>
    public void AddStudent()
    {
        var studentViewModel = new AddStudentViewModel();

        Observable.Merge(
            studentViewModel.Ok,
            studentViewModel.Cancel.Select(_ => (Student)null!))
            .Take(1)
            .Subscribe(model => 
            {
                if(model != null)
                {
                    db.AddStudent(model);
                    Students.Students = new ObservableCollection<Student>(db.GetStudents());
                }

                Content = Students;
            });
        Content = studentViewModel;
    }
    
    /// <summary>
    /// Método responsável por adicionar professores(as) ao sistema ao clicar no botão "Add Teacher".
    /// </summary>
    public void AddTeacher()
    {
        var teacherViewModel = new AddTeacherViewModel();

        Observable.Merge(
            teacherViewModel.Ok,
            teacherViewModel.Cancel.Select(_ => (Teacher)null!))
            .Take(1)
            .Subscribe(model => 
            {
                if(model != null)
                {
                    db.AddTeacher(model);
                    Teachers.Teachers = new ObservableCollection<Teacher>(db.GetTeachers());
                }

                Content = Teachers;
            });
        Content = teacherViewModel;
    }
    
    /// <summary>
    /// Método responsável por adicionar disciplinas ao sistema ao clicar no botão "Add Discipline".
    /// </summary>
    public void AddDiscipline()
    {
        var disciplineViewModel = new AddDisciplineViewModel();

        Observable.Merge(
            disciplineViewModel.Ok,
            disciplineViewModel.Cancel.Select(_ => (Discipline)null!))
            .Take(1)
            .Subscribe(model => 
            {
                if(model != null)
                {
                    db.AddDiscipline(model);
                    Disciplines.Disciplines = new ObservableCollection<Discipline>(db.GetDisciplines());
                }

                Content = Disciplines;
            });
        Content = disciplineViewModel;
    }

    /// <summary>
    /// Carrega a tela de listagem dos(as) alunos(as) cadastradas no sistema.
    /// </summary>
    public void ListStudents()
    {
        Students.Students = new ObservableCollection<Student>(db.GetStudents());
        Content = Students;
    }
    
    /// <summary>
    /// Carrega a tela de listagem dos(as) professores(as) cadastradas no sistema.
    /// </summary>
    public void ListTeachers()
    {
        Teachers.Teachers = new ObservableCollection<Teacher>(db.GetTeachers());
        Content = Teachers;
    }
    
    /// <summary>
    /// Carrega a tela de listagem dos disciplinas cadastradas no sistema.
    /// </summary>
    public void ListDisciplines()
    {
        Disciplines.Disciplines = new ObservableCollection<Discipline>(db.GetDisciplines());
        Content = Disciplines;
    }
    
    /// <summary>
    /// Volta a tela do menu de seleção    
    /// </summary>
    public void BackToMenu()
    {
        Content = new MenuWindowViewModel();
    }

}

