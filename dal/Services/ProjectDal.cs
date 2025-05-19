<<<<<<< HEAD
﻿using dal.Api;
using dal.Models;
=======
﻿using bl.Models;
>>>>>>> c36a81bac47abf75ca32da352e3306b4f00a12ed
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Services
{
<<<<<<< HEAD
    internal class ProjectDal:IProjectDalService
=======
    internal class ProjectDal
>>>>>>> c36a81bac47abf75ca32da352e3306b4f00a12ed
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
