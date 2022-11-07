using MiPrimeritaAPI.DAL.Contracts;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Implementations
{
    public class UserDAL : IUserDAL
    {
        public TareaContext Context { get; set; }

        public UserDAL(TareaContext Context)
        {
            this.Context = Context;
        }

        public void Insert(User u)
        {
            Context.Users.Add(u);
            Context.SaveChanges();
        }

        public User? GetUser(string Name)
        {
            return Context.Users.FirstOrDefault(u => u.Name == Name);
        }

        public User? GetUser(string Name, string Email)
        {
            return Context.Users.FirstOrDefault(u => u.Name == Name && u.Email == Email);
        }

        public List<User> GetUsers()
        {
            return Context.Users.ToList();
        }
    }
}
