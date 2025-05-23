using bl.Api;
using bl.Models;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        IBLProjectService _IBLProjectService;


        
    }
}
