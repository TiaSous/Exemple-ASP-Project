using System;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure;
using Infrastructure.Repositories;

namespace UnitTest
{
    public class Tests
    {
        private IDbContextFactory<ToDoDbContext> _contextFactory;
        private IUserRepository _userRepository;
        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();
            services.AddDbContextFactory<ToDoDbContext>(options =>
                options.UseInMemoryDatabase("TestDb"));
            services.AddScoped<IUserRepository, UserRepository>();

            var serviceProvider = services.BuildServiceProvider();

            _contextFactory = serviceProvider.GetRequiredService<IDbContextFactory<ToDoDbContext>>();
            _userRepository = serviceProvider.GetRequiredService<IUserRepository>();
        }

        [Test]
        public void RepositoryAddUserTest()
        {
            var user = new UserEntity
            {
                Name = "John",
                Age = 18,
                Password = "Strong Password"
            };
            _userRepository.AddUser(user).Wait();

            using (var context = _contextFactory.CreateDbContext())
            {
                var countUser = context.Users.Count();

                Assert.That(countUser, Is.EqualTo(1));
            }
        }
    }
}