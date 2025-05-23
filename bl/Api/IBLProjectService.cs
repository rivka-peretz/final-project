using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal.Models;



namespace bl.Api
{
    public interface IBLProjectService
    {
        public bool AddProject(BLProject project);
        public bool DeleteProject(string name);
        public BLProject GetProjectByName(string name);
        public List<BLProject> GetAllCurrentProjects();
        //public List<IBLProject> GetAllProjectsOfTheTeamLeader(int teamLeaderId);

    }
}
