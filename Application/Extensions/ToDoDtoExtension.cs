using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Domain.OM;
using Infrastructure.Entities;

namespace Application.Extensions
{
    public static class ToDoDtoExtension
    {
        public static OMToDo ToObjectModel(this ToDoDto toDoDto)
        {
            return new OMToDo()
            {
                Title = toDoDto.Title,
                Description = toDoDto.Description,
                UserId = toDoDto.UserId,
                IsFinished = toDoDto.IsFinished ?? false
            };

        }
    }
}
