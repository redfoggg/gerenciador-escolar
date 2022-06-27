using System.Collections.Generic;
using System.Collections.ObjectModel;
using gerenciador.escolar.Models;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels;

/// <summary>
/// Classe responsável pelo comportamento da tela de listagem de professores.
/// </summary>
public class TeacherListViewModel : ReactiveObject
{
    /// <summary>
    /// Classe responsável pelo comportamento da tela de listagem de professores.
    /// </summary>
    /// <param name="teachers">Uma coleção de professores</param>
    public TeacherListViewModel(IEnumerable<Teacher> teachers)
    {
        Teachers = new ObservableCollection<Teacher>(teachers);
    }

    /// <summary>
    /// Coleção de professores com ferramentas de notificação para quando
    /// há alterações em seus valores.
    /// </summary>
    public ObservableCollection<Teacher> Teachers { get; set; }
}
