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
        public WorkersController(IBlWorkerService blWorkerService)
        {
            _IBlWorkerService = blWorkerService;
        }
        
        
        [HttpPost]
        public IActionResult AddWorker([FromBody] BLWorker worker, [FromQuery] int teamLeaderId)
        {
            if (_IBlWorkerService.AddWorker(worker, teamLeaderId))
            {
                return Ok("true");
            }
            else return BadRequest("false");
        }
        [HttpPost("AddManagement")] 
        public IActionResult AddManagement([FromBody] BLWorker worker)
        {
            if (_IBlWorkerService.Addmanagement(worker))
            {
                return Ok("true");
            }
            else return BadRequest("false");
        }

        [HttpDelete]
        public IActionResult RemoveWorker([FromQuery] int id)
        {
            if (_IBlWorkerService.RemoveWorker(id))
            {
                return Ok("true");
            }
            else return BadRequest("false");
        }

        [HttpGet]
        //public BLWorker GetWorker(int id)
        //{
        //    return _IBlWorkerService.GetWorker(id);
        //}
        
        public IActionResult GetWorker([FromQuery] int id)
        {
            var worker = _IBlWorkerService.GetWorker(id);
            if (worker == null)
                return NotFound("Worker not found");
            return Ok(worker);
        }


    }
}
