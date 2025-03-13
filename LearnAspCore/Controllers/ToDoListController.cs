using System.Formats.Asn1;
using Application.MediatR.Commands;
using Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Repositories;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoListController
    {
        private readonly ILogger<ToDoListController> _logger;
        private readonly IMediator _mediator;
        public ToDoListController(ILogger<ToDoListController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        public async Task AddTodo(ToDoDto toDoDto)
        {
            await _mediator.Send(new CreateToDoCommand(toDoDto));
        }
    }
}
