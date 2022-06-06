using System.Collections.Generic;
using System.Collections.ObjectModel;
using gerenciador.escolar.Models;
using ReactiveUI;

namespace gerenciador.escolar.ViewModels;

public class StudentListViewModel : ReactiveObject
{
    public StudentListViewModel(IEnumerable<Student> students)
    {
        Students = new ObservableCollection<Student>(students);
    }

    public ObservableCollection<Student> Students { get; set; }
}
