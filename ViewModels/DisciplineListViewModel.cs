using System.Collections.Generic;
using System.Collections.ObjectModel;
using gerenciador.escolar.Models;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels;

/// <summary>
/// Classe responsável pelo comportamento da tela de listagem de disciplinas.
/// </summary>
public class DisciplineListViewModel : ReactiveObject
{
    /// <summary>
    /// Classe responsável pelo comportamento da tela de listagem de disciplinas.
    /// </summary>
    /// <param name="disciplines">Uma coleção de disciplinas</param>
    public DisciplineListViewModel(IEnumerable<Discipline> disciplines)
    {
        Disciplines = new ObservableCollection<Discipline>(disciplines);
    }

    /// <summary>
    /// Coleção de disciplinas com ferramentas de notificação para quando
    /// há alterações em seus valores.
    /// </summary>
    public ObservableCollection<Discipline> Disciplines { get; set; }
}
