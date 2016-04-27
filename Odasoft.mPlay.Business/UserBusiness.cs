using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    class UserBusiness
    {
        public ICollection<User> GetUsers()
        {
            var Users = new List<User>();
            Users.Add(new User
            {
                Email = "juanini@juanini.com",
                Name= "Juanito Lopez",
                UserName="JuanitoLopez",
                Password="1234",
                Id=232
            });

            Users.Add(new User
            {
                Email = "juanini@juanini.com",
                Name = "Juanito Lopez",
                UserName = "JuanitoLopez",
                Password = "1234",
                Id=343
            });

            return Users;
        }

        public User GetUserById(int UserId)
        {
            return new User() {
                Email = "juanini@get.com",
                Name = "Juanito Lopez",
                UserName = "JuanitoLopez",
                Password = "1234"
            };
            
        }

        public User CreateUser(User model)
        {
            return new User()
            {
                Email = "juanini@new.com",
                Name = "Juanito Lopez",
                UserName = "JuanitoLopez",
                Password = "1234"
            };
        }

        public void DeleteUserById(int UserId)
        {

            // Delete User DB
        }

        public User EditUserById(User model)
        {
            return new User()
            {
                Email = "juanini@edit.com",
                Name = "Juanito Lopez",
                UserName = "JuanitoLopez",
                Password = "1234"
            };
        }

    }

}
