using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Domain.OM;

namespace Application.Extensions
{
    public static class UserDtoExtension
    {
        public static OMUser ToObjectModel(this UserDto userDto)
        {
            return new OMUser
            {
                Age = userDto.Age,
                Name = userDto.Name,
                Password = userDto.Password
            };
        }
    }
}
