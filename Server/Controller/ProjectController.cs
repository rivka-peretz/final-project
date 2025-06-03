using bl.Api;
using bl.Models;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IBLProjectService _projectService;

        public ProjectsController(IBLProjectService projectService)
        {
            _projectService = projectService;
        }

        // POST: api/Projects
        [HttpPost]
        public IActionResult AddProject([FromBody] BLProject project)
        {
            if (_projectService.AddProject(project))
                return Ok(true);
            return BadRequest("Failed to add project");
        }

        // DELETE: api/Projects/{name}
        [HttpDelete("{name}")]
        public IActionResult DeleteProject(string name)
        {
            if (_projectService.DeleteProject(name))
                return Ok(true);
            return NotFound($"Project with name '{name}' not found");
        }

        // GET: api/Projects/{name}
        [HttpGet("{name}")]
        public ActionResult<BLProject> GetProjectByName(string name)
        {
            var project = _projectService.GetProjectByName(name);
            if (project == null)
                return NotFound($"Project with name '{name}' not found");
            return Ok(project);
        }

        // GET: api/Projects
        [HttpGet]
        public ActionResult<List<BLProject>> GetAllCurrentProjects()
        {
            return Ok(_projectService.GetAllCurrentProjects());
        }
    }
}
