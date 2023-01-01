using Application.Projects;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class ProjectController : BaseApiController
    {
 
        [HttpGet]
        public async Task<IActionResult> GetProjects(CancellationToken ct)
        {
            return HandleResult(await Mediator.Send(new List.Query(), ct));
        }

        [HttpPost]  
        public async Task<ActionResult>CreateProject(Project project)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Project=project}));
        }
    }
}
