using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.OM;
using Infrastructure.Entities;

namespace Infrastucture.Extensions
{
    public static class OMUserExtension
    {
        public static UserEntity ToEntity(this OMUser omUser)
        {
            return new UserEntity
            {
                Age = omUser.Age,
                Name = omUser.Name,
                Password = omUser.Password
            };
        }
    }
}
