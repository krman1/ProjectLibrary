using ProjectLibrary.Entities;

namespace ProjectLibrary.Reposirories
{
    public class ProjectRepositories
    {
        private readonly List<Project> _projects = new();
        public void Add(Project project) 
        {
            project.Id = _projects.Count + 1;
            _projects.Add(project);
        }
        public Project GetById(int id)
        {
            return _projects.Single(item => item.Id == id);
        }
        public void Save()
        {
            foreach (var project in _projects)
            {
                Console.WriteLine(project);
            }
        }
        
    }
}
