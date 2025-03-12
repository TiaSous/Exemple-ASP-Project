using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Azure;
using MediatR;

namespace Application.MediatR.Commands
{
    public class CreateUserCommand : IRequest
    {
        public UserDto UserDto { get; set; }
        
        public CreateUserCommand(UserDto dto)
        {
            UserDto = dto;
        }
    }
}
