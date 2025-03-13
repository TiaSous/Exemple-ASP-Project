using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(UserEntity user);
    }
}
