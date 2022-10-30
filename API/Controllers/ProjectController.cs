using Application.Projects;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class ProjectController : BaseApiController
    {
        private readonly IMediator _mediator;
        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects(CancellationToken ct)
        {
            return await _mediator.Send(new List.Query(),ct);
        }

        [HttpPost]  
        public async Task<ActionResult>CreateProject(Project project)
        {
            return Ok(await _mediator.Send(new Create.Command { Project=project}));
        }
    }
}
