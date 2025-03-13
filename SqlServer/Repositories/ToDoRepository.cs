using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.OM;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using Infrastucture.Extensions;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class ToDoRepository : ITodoRepository
    {
        private readonly IDbContextFactory<ToDoDbContext> _context;

        public ToDoRepository(IDbContextFactory<ToDoDbContext> context)
        {
            _context = context;
        }

        public async Task AddTodo(OMToDo toDo)
        {
            using (var dbContext = _context.CreateDbContext())
            {
                dbContext.ToDos.Add(toDo.ToEntity());

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
