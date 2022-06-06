using System.Reactive.Linq;
using gerenciador.escolar.Models;
using gerenciador.escolar.Services;
using System;
using ReactiveUI;
using System.Linq;
using System.Collections.ObjectModel;

namespace gerenciador.escolar.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        ReactiveObject content;
        Database db;

        public MainWindowViewModel(Database db)
        {
            Students = new StudentListViewModel(db.GetStudents());
            Content = Students;
            this.db = db;
        }

        public ReactiveObject Content 
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
                        //Students.Students.Add(model);
                        db.AddStudent(model);
                        Students.Students = new ObservableCollection<Student>(db.GetStudents());
                    }

                    Content = Students;
                });
            Content = studentViewModel;
        }

    }
}
