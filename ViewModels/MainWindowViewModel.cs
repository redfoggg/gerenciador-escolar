using System.Reactive.Linq;
using gerenciador.escolar.Models;
using gerenciador.escolar.Services;
using System;
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

        public void AddStudent()
        {
            var studentViewModel = new AddStudentViewModel();

            Observable.Merge(
                studentViewModel.Ok,
                studentViewModel.Cancel.Select(_ => (Student)null))
                .Take(1)
                .Subscribe(model => 
                {
                    if(model != null)
                    {
                        Students.Students.Add(model);
                    }

                    Content = Students;
                });
            Content = studentViewModel;
        }

    }
}
