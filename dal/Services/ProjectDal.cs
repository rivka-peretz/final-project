using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Services
{
    internal class ProjectDal
    {
        dbClass context;
        public void AddProject(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
        }
        public void RemoveProject(Project project) {
            context.Projects.Remove(project);
            context.SaveChanges();
        }
        public Project SearchForAProjectByName(string name)
        {
            return context.Projects.FirstOrDefault(p => p.NameProject == name);
        }
        //public List<Project> GetAllTasks()
        //{
        //    return context.Projects.Tasks.ToList();
        //}


    }
}
