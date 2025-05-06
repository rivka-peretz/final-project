using bl.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bl.Api;



namespace Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        IBlWorkerService _IBlWorkerService;
        [HttpPost]
        public IActionResult AddWorker([FromBody] BLWorker worker, [FromBody] string AdministratorPassword)
        {
            if (_IBlWorkerService.AddWorker(worker, AdministratorPassword))
            {
                return Ok("true");
            }
            else return BadRequest("false");
        }
        [HttpDelete]
        public IActionResult RemoveWorker([FromBody] int id, [FromBody] string AdministratorPassword)
        {
            if (_IBlWorkerService.RemoveWorker(id, AdministratorPassword))
            {
                return Ok("true");
            }
            else return BadRequest("false");
        }
        [HttpGet]
        public BLWorker GetWorker(int id)
        {
            return _IBlWorkerService.GetWorker(id);
        }
    }
}
