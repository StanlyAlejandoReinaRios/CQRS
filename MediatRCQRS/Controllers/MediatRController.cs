using MediatR;
using MediatRCQRS.Library.Commands;
using MediatRCQRS.Library.Models;
using MediatRCQRS.Library.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatRController : ControllerBase
    {
            private readonly IMediator _mediator;

            public MediatRController(IMediator mediator)
            {
                _mediator = mediator;
            }

            [HttpGet]
            public async Task<List<Usuarios>> Get()
            {
                return await _mediator.Send(new GetUsuariosListQueries());
            }

            [HttpPost]
            public async Task<Usuarios> Post(Usuarios usuarios)
            {
                return await _mediator.Send(new AddUsuarioCommand(usuarios));
            }

        
    }
}
