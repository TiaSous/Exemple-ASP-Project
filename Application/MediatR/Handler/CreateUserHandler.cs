using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Extensions;
using Application.MediatR.Commands;
using Infrastructure.Interfaces;
using MediatR;

namespace Application.MediatR.Handler
{
    class CreateUserHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        { 
            await _userRepository.AddUser(request.UserDto.ToEntity());
        }
    }
}
