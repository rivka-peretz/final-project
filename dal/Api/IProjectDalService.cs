using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using dal.Models;
=======
using bl.Models;
>>>>>>> c36a81bac47abf75ca32da352e3306b4f00a12ed

namespace dal.Api
{
    public interface IProjectDalService
    {
        public void AddProject(Project project);
        public Project SearchForAProjectByName(string name);
        public void RemoveProject(Project project);
    
    }
}
