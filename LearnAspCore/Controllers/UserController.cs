using Application.MediatR.Commands;
using Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Controllers;

namespace LearnAspCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly ILogger<ToDoListController> _logger;
        private readonly IMediator _mediator;
        public UserController(ILogger<ToDoListController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        public async Task AddUser(UserDto UserDto)
        {
            await _mediator.Send(new CreateUserCommand(UserDto));
        }
    }
}
