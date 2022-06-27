using System.Reactive;
using gerenciador.escolar.Models;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels;

/// <summary>
/// Classe responsável pelo comportamento da tela de adição de disciplina.
/// </summary>
public class AddDisciplineViewModel : ReactiveObject
{

    /// <summary>
    /// Construtor da AddDisciplineViewModel onde é verificado se existe um valor na property
    /// Name, havendo este valor fica liberado pressionar o botão OK, aqui também se define
    /// o comportamento para o botão de Ok bem como o comportamento para o botão de Cancelamento.
    /// </summary>
    public AddDisciplineViewModel()
    {
        var okEnabled = this.WhenAnyValue(
            x => x.Name,
            x => !string.IsNullOrWhiteSpace(x));

        Ok = ReactiveCommand.Create(
                () => new Discipline(Name, Id), 
                okEnabled);
        Cancel = ReactiveCommand.Create(() => { });
    }

    /// <summary>
    /// field(campo) que armazena o valor do nome inputado na tela de adição de disciplina
    /// </summary>
    string? name;
    
    /// <summary>
    /// field(campo) que armazena o valor do nome inputado na tela de adição de disciplina
    /// </summary>
    string? id;

    /// <summary>
    /// property(propriedade) que dá acesso ao o nome inputado na tela de adição de disciplina
    /// </summary>
    public string Name 
    {
        get => name!;
        set => this.RaiseAndSetIfChanged(ref name, value);
    }

    /// <summary>
    /// property(propriedade) que dá acesso ao o Id inputado na tela de adição de disciplina
    /// </summary>
    public string Id 
    {
        get => id!;
        set => this.RaiseAndSetIfChanged(ref id, value);
    }
   
    /// <summary>
    /// property(propriedade) que controla a ação do botão de Ok 
    /// </summary>
    public ReactiveCommand<Unit, Discipline> Ok { get; }
    
    /// <summary>
    /// property(propriedade) que controla a ação do botão de Cancelamento
    /// </summary>
    public ReactiveCommand<Unit, Unit> Cancel { get; }

}
