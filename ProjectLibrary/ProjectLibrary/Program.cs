using ProjectLibrary.Entities;
using ProjectLibrary.Reposirories;

var projectRepositories = new GenericProjectRepositories<Project>();
projectRepositories.Add(new ProjectLibrary.Entities.Project { Name = "Chawelańska", City = "Poznań", Architect = "Minkiewicz", Description = "Budynek wielorodzinny" });
projectRepositories.Add(new ProjectLibrary.Entities.Project { Name = "Grabiszyńska", City = "Łódź", Architect = "Kowalski", Description = "Hotel" });
projectRepositories.Save();