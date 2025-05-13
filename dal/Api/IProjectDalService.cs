using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bl.Models;

namespace dal.Api
{
    public interface IProjectDalService
    {
        public void AddProject(Project project);
        public Project SearchForAProjectByName(string name);
        public void RemoveProject(Project project);
    
    }
}
