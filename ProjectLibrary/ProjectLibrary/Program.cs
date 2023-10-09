using ProjectLibrary.Reposirories;

var projectRepositories = new ProjectRepositories();
projectRepositories.Add(new ProjectLibrary.Entities.Project { Name = "Chawelańska", City = "Poznań", Architect = "Minkiewicz", Description = "Budynek wielorodzinny" });
projectRepositories.Add(new ProjectLibrary.Entities.Project { Name = "Grabiszyńska", City = "Łódź", Architect = "Kowalski", Description = "Hotel" });
projectRepositories.Save();