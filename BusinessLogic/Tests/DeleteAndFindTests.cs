using BusinessLogic.Models;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.CrudExecutors;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessLogic.Tests
{
    public class DeleteAndFindTests : IClassFixture<DbContextFixture>
    {
        private readonly DbContextFixture DbContextFixture;

        public DeleteAndFindTests(DbContextFixture dbContextFixture)
        {
            DbContextFixture = dbContextFixture;
        }

        [Fact]
        public void DeleteWorksProperly()
        {
            var deleteExecutor = new DeleteExecutor<User>(DbContextFixture.Context,DbContextFixture.Mapper);

            deleteExecutor.Execute(1);

            var roleWithIdOne = DbContextFixture.Context.Users.Find(1);

            roleWithIdOne.Should().Be(null);
        }

        [Fact]
        public void FindWorksProperly()
        {
            var findExecutor = new FindExecutor<Role,RoleDto>(DbContextFixture.Context, DbContextFixture.Mapper);

            var role = findExecutor.Execute(2);

            role.Name.Should().Be("Role 2");
        }
    }
}
