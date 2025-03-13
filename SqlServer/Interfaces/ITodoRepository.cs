using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace Infrastructure.Interfaces
{
    public interface ITodoRepository
    {
        Task AddTodo(ToDoEntity toDo);
    }
}
