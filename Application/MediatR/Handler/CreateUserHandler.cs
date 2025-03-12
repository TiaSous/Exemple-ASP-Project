using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MediatR.Commands;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using SqlServer.Repositories;

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
            var user = new UserEntity
            {
                Age = request.UserDto.Age,
                Name = request.UserDto.Name,
                Password = request.UserDto.Password
            };
            await _userRepository.AddUser(user);
        }
    }
}
