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
    public class UserRepository : IUserRepository
    {
        private readonly IDbContextFactory<ToDoDbContext> _context;

        public UserRepository(IDbContextFactory<ToDoDbContext> context)
        {
            _context = context;
        }

        public async Task AddUser(OMUser user)
        {
            using(var dbContext = _context.CreateDbContext())
            {
                dbContext.Users.Add(user.ToEntity());

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
