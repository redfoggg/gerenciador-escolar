using System.Collections.Generic;
using System.Collections.ObjectModel;
using gerenciador.escolar.Models;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels;

/// <summary>
/// Classe responsável pelo comportamento da tela de listagem de alunos.
/// </summary>
public class StudentListViewModel : ReactiveObject
{

    /// <summary>
    /// Classe responsável pelo comportamento da tela de listagem de alunos.
    /// </summary>
    /// <param name="students">Uma coleção de estudantes</param>
    public StudentListViewModel(IEnumerable<Student> students)
    {
        Students = new ObservableCollection<Student>(students);
    }

    /// <summary>
    /// Coleção de estudantes com ferramentas de notificação para quando
    /// há alterações em seus valores.
    /// </summary>
    public ObservableCollection<Student> Students { get; set; }
}
