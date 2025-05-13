using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Api
{
    public interface IBLProjectService
    {
        //public bool AddProject(IBLProject project, string AdministratorPassword);
        public bool DeleteProject(string name, string AdministratorPassword);
        public Project GetProjectByName(string name);


    }
}
