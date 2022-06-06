using System.Reactive;
using gerenciador.escolar.Models;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels;

public class AddStudentViewModel : ReactiveObject
{
    string name;

    public string Name 
    {
        get => name;
        set => this.RaiseAndSetIfChanged(ref name, value);
    }
    
    public ReactiveCommand<Unit, Student> Ok { get; }
    
    public ReactiveCommand<Unit, Unit> Cancel { get; }
    
    public AddStudentViewModel()
    {
        var okEnabled = this.WhenAnyValue(
            x => x.Name,
            x => !string.IsNullOrWhiteSpace(x));

        Ok = ReactiveCommand.Create(
                () => new Student(Name), 
                okEnabled);
        Cancel = ReactiveCommand.Create(() => { });
    }

}
