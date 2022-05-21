using System.Collections.Generic;
using System.Collections.ObjectModel;
using gerenciador.escolar.Models;

namespace gerenciador.escolar.ViewModels;

public class StudentListViewModel : ViewModelBase
{
    public StudentListViewModel(IEnumerable<Student> students)
    {
        Students = new ObservableCollection<Student>(students);
    }

    public ObservableCollection<Student> Students { get; }
}
