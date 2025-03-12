using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Application.MediatR.Commands;
using SqlServer.Repositories;
using Domain.Entities;

namespace Application.MediatR.Handler
{
    public class CreateToDoHandler : IRequestHandler<CreateToDoCommand>
    {
        private readonly ToDoRepository _toDoRepository;
        public CreateToDoHandler (ToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        public async Task Handle(CreateToDoCommand request, CancellationToken cancellationToken)
        {
            var todo = new ToDoEntity
            {
                Title = request.toDoDto.Title,
                Description = request.toDoDto.Description,
                IsFinished = false,
                UserId = request.toDoDto.UserId
            };

            await _toDoRepository.addTodo(todo);
        }
    }
}
