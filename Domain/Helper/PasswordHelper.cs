using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.OM;
using Microsoft.AspNetCore.Identity;


namespace Domain.Helper
{
    public class PasswordHelper : IPasswordHelper
    {
        private readonly IPasswordHasher<OMUser> _passwordHasher;

        public PasswordHelper(IPasswordHasher<OMUser> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public string HashPassword(OMUser user, string password)
        {
            return _passwordHasher.HashPassword(user, password);
        }
    }
}
