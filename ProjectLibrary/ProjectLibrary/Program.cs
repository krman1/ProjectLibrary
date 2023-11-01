using ProjectLibrary.Data;
using ProjectLibrary.Entities;
using ProjectLibrary.Reposirories;

/*var projectRepositories = new GenericProjectRepositories<Project>();
projectRepositories.Add(new Project { Name = "Chawelańska", City = "Poznań", Architect = "Minkiewicz", Description = "Budynek wielorodzinny" });
projectRepositories.Add(new Project { Name = "Grabiszyńska", City = "Łódź", Architect = "Kowalski", Description = "Hotel" });
projectRepositories.Save();*/

var sqlRepository = new SqlRepository<Project>(new ProjectLibraryDbContext());
sqlRepository.Add(new ProjectLibrary.Entities.Project { Name = "Chawelańska", City = "Poznań", Architect = "Minkiewicz", Description = "Budynek wielorodzinny" });
sqlRepository.Add(new ProjectLibrary.Entities.Project { Name = "Grabiszyńska", City = "Łódź", Architect = "Kowalski", Description = "Hotel" });
sqlRepository.Save();
var pro = sqlRepository.GetById(2);
Console.WriteLine(pro.ToString());