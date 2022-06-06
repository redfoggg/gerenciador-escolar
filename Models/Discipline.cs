namespace gerenciador.escolar.Models;

public class Discipline : IdentificationBase<string>
{
    public Discipline(string name, string[] topics, string classes, string id) : base(id)
    {
        Name = name;
        Topics = topics;
        Classes = classes;
    }

    public string Name { get; }
    public string[] Topics { get; }
    public string Classes { get; }
}

