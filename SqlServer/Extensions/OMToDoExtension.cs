using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.OM;
using Infrastructure.Entities;

namespace Infrastucture.Extensions
{
    public static class OMToDoExtension
    {
        public static ToDoEntity ToEntity(this OMToDo omToDo)
        {
            return new ToDoEntity
            {
                Description = omToDo.Description,
                Title = omToDo.Title,
                UserId = omToDo.UserId,
                IsFinished = omToDo.IsFinished,
            };
        }
    }
}
