using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Extensions;
using Application.MediatR.Commands;
using Domain.Helper;
using Domain.Interfaces;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.MediatR.Handler
{
    class CreateUserHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHelper _passwordHelper;
        public CreateUserHandler(IUserRepository userRepository, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _passwordHelper = passwordHelper;
        }
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userOM = request.UserDto.ToObjectModel();
            userOM.Password = _passwordHelper.HashPassword(userOM, userOM.Password);
            await _userRepository.AddUser(userOM);
        }
    }
}
