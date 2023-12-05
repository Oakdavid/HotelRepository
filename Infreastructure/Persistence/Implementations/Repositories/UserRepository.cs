using Dapper;
using Hotel.Core.Application.Interfaces.IRepositories;
using Hotel.Core.Domain.Entities;
using Hotel.Infreastructure.Persistence.Context;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infreastructure.Persistence.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        StartUp startup = new StartUp();
        public void Create(User user)
        {
            var qry = $"insert into user(Id, Email, Password, Role, IsDeleted) values ('{user.Id}','{user.Email}','{user.Password}','{user.Role}','{user.IsDeleted}')";
            using(var con = startup.Connection())
            {
                var row = con.Execute(qry);
            }
        }

        public User Get(string email)
        {
            var qry = $"select * from user where email = {email}";
            using (var con = startup.Connection())
            {
                var user =  con.QuerySingleOrDefault<User>(qry);
                return user;
            }
        }

        public List<User> GetAll()
        {
            var qry = $"select * from user";
            using (var con = startup.Connection())
            {
                var user = con.Query<User>(qry);
                return user.ToList();
            }
        }
    }
}
