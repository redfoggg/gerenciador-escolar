using System.Collections.Generic;
using gerenciador.escolar.Models;

namespace gerenciador.escolar.Services;

public class Database
{
    public IEnumerable<Student> GetStudents() => new []
    {
        new Student { Name = "Jordan", RegistrationNumber = "31023939" },
        new Student { Name = "Maria", RegistrationNumber = "12324123" }
    };
}
