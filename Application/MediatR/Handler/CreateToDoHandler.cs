using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Application.MediatR.Commands;
using Infrastructure.Interfaces;
using Infrastructure.Entities;
using Application.Extensions;

namespace Application.MediatR.Handler
{
    public class CreateToDoHandler : IRequestHandler<CreateToDoCommand>
    {
        private readonly ITodoRepository _toDoRepository;
        public CreateToDoHandler (ITodoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        public async Task Handle(CreateToDoCommand request, CancellationToken cancellationToken)
        {
            var omTodo = request.toDoDto.ToObjectModel();
            await _toDoRepository.AddTodo(omTodo);
        }
    }
}
