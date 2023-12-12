using ProjectLibrary.Data;
using ProjectLibrary.Entities;
using ProjectLibrary.Reposirories;

var projectRepository = new SqlRepository<Project>(new ProjectLibraryDbContext());
AddProjects(projectRepository);
WriteAllToConsole(projectRepository);
WriteById(projectRepository);

static void AddProjects(IRepository<Project> projectRepository)
{
    var projects = new[]
    {
    new ProjectLibrary.Entities.Project { Name = "Chawelańska", City = "Poznań", Architect = "Minkiewicz", Description = "Budynek wielorodzinny" },
    new ProjectLibrary.Entities.Project { Name = "Grabiszyńska", City = "Łódź", Architect = "Kowalski", Description = "Hotel" },
    new ProjectLibrary.Entities.Project { Name = "Dymka", City = "Poznań", Architect = "Nowak", Description = "Biura" },
    };
    AddBatch(projectRepository, projects);
}

static void AddBatch<T>(IRepository<T> repository, T[] items) 
    where T : class, IEntity
{
    foreach(var item in items)
    {
        repository.Add(item);
    }
    repository.Save();
}

static void WriteAllToConsole(IRepository<Project> readRepository)
{
    var items = readRepository.GetAll();
    foreach ( var item in items )
        Console.WriteLine(item);
}
static void WriteById(IRepository<Project> readRepository)
{
    var items = readRepository.GetById(3);
    Console.WriteLine(items);
}
