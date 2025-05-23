using dal.Api;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Services
{
    public class ProjectDal:IProjectDalService
    {
        private readonly dbClass context;

        public ProjectDal(dbClass dbContext)
        {
            context = dbContext;
        }

        public void AddProject(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
        }

        public void RemoveProject(Project project)
        {
            context.Projects.Remove(project);
            context.SaveChanges();
        }

        public Project SearchForAProjectByName(string name)
        {
            return context.Projects.FirstOrDefault(p => p.NameProject == name);
        }


        public List<Project> GetAllCurrentProjects()
        {
            try
            {
                return context.Projects
                    .Where(p => p.SubmissionDate > DateOnly.FromDateTime(DateTime.Now))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving current projects", ex);
            }
        }


        //public List<Task> GetAllTasks()
        //{
        //    return context.Projects.Tasks.ToList();
        //}
    }
}


