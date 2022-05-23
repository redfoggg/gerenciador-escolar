using System.Reactive;
using gerenciador.escolar.Models;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels;

public class AddStudentViewModel : ViewModelBase
{
    string name;
    string registrationNumber;

    public string Name 
    {
        get => name;
        set => this.RaiseAndSetIfChanged(ref name, value);
    }
    
    public string RegistrationNumber 
    {
        get => registrationNumber;
        set => this.RaiseAndSetIfChanged(ref registrationNumber, value);
    }
    
    public ReactiveCommand<Unit, Student> Ok { get; }
    
    public ReactiveCommand<Unit, Unit> Cancel { get; }
    
    public AddStudentViewModel()
    {
        var okEnabled = this.WhenAnyValue(
            x => x.Name,
            x => !string.IsNullOrWhiteSpace(x));

        Ok = ReactiveCommand.Create(
                () => new Student { Name = Name, RegistrationNumber = RegistrationNumber }, 
                okEnabled);
        Cancel = ReactiveCommand.Create(() => { });
    }

}
