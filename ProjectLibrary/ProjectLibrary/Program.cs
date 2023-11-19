using ProjectLibrary.Data;
using ProjectLibrary.Entities;
using ProjectLibrary.Reposirories;



var projectRepository = new SqlRepository<Project>(new ProjectLibraryDbContext());
AddProjects(projectRepository);
WriteAllToConsole(projectRepository);
WriteById(projectRepository);

static void AddProjects(IWriteRepository<Project> projectRepository)
{
    projectRepository.Add(new ProjectLibrary.Entities.Project { Name = "Chawelańska", City = "Poznań", Architect = "Minkiewicz", Description = "Budynek wielorodzinny" });
    projectRepository.Add(new ProjectLibrary.Entities.Project { Name = "Grabiszyńska", City = "Łódź", Architect = "Kowalski", Description = "Hotel" });
    projectRepository.Add(new ProjectLibrary.Entities.Project { Name = "Dymka", City = "Poznań", Architect = "Nowak", Description = "Biura" });
    projectRepository.Save();
}

static void WriteAllToConsole(IReadRepository<Project> readRepository)
{
    var items = readRepository.GetAll();
    foreach ( var item in items )
        Console.WriteLine(item);
}
static void WriteById(IRepository<Project> readRepository)
{
    var items = readRepository.GetById(2);
    Console.WriteLine(items);
}
