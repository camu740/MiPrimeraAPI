using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Contracts
{
    public interface IUserDAL
    {
        public void Insert(User u);
        public List<User> GetUsers();
        public User? GetUser(string Name, string Email);
        public User? GetUser(string Name);

    }
}
