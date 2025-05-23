using bl.Api;
using bl.Models;
using dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal.Models;
using dal.Services;

namespace bl.Services
{
    public class ProjectBl : IBLProjectService
    {
        private IWorkerDalService _IworkerDal;
        private IProjectDalService _iprojectDal;
        public bool AddProject(BLProject project)
        {
            if (project == null) return false;
            if (string.IsNullOrEmpty(project.NameProject)) return false;
            if (project.SubmissionDate == null) return false;
            Project project1 = new Project();
            project1.Id = project1.Id;
            project1.NameProject = project.NameProject;
            project1.SubmissionDate = project.SubmissionDate;
            _iprojectDal.AddProject(project1);
            return true;
        }
        public bool DeleteProject(string name)
        {
            Project project = _iprojectDal.SearchForAProjectByName(name);
            if (project == null) return false;
            _iprojectDal.RemoveProject(project);
            return true;
        }

        public BLProject GetProjectByName(string name)
        {
            Project project = _iprojectDal.SearchForAProjectByName(name);
            if (project == null) return null;
            return new BLProject(project.Id, project.NameProject, project.SubmissionDate);
        }
        public List<BLProject> GetAllCurrentProjects()
        {
            return _iprojectDal.GetAllCurrentProjects()
                .Select(p => new BLProject(p.Id, p.NameProject, p.SubmissionDate))
                .ToList();
        }
    }

    //public List<IBLTask> GetAllTasks()
    //{
    //    List<IBLTask> tasks = new List<IBLTask>();
    //    foreach (var task in _iprojectDal.GetAllTasks())
    //    {
    //        tasks.Add(task);
    //    }
    //    return tasks;
    //}
    //public List<IBLProject> GetAllProjectsOfTheTeamLeader(int teamLeaderId)
    //{

    //}


}