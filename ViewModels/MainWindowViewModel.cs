using gerenciador.escolar.Services;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;

        public MainWindowViewModel(Database db)
        {
            Students = new StudentListViewModel(db.GetStudents());
            Content = Students;
        }

        public ViewModelBase Content 
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public StudentListViewModel Students { get; }

        public void AddStudent() => Content = new AddStudentViewModel();
    }
}
