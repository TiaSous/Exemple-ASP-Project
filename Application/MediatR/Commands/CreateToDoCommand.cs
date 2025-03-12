using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using MediatR;

namespace Application.MediatR.Commands
{
    public class CreateToDoCommand : IRequest
    {
        public ToDoDto toDoDto { get; set; }

        public CreateToDoCommand(ToDoDto dto)
        {
            this.toDoDto = dto;
        }
    }
}
