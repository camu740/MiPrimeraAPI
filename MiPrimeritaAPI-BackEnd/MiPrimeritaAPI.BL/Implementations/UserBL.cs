using AutoMapper;
using MiPrimeritaAPI.BL.Contracts;
using MiPrimeritaAPI.CORE.DTO;
using MiPrimeritaAPI.DAL.Contracts;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.BL.Implementations
{
    public class UserBL : IUserBL
    {
        public IUserDAL userDAL { get; set; }
        public IMapper mapper { get; set; }

        public bool Insert(UserDTO userDTO)
        {
            var user = userDAL.GetUser(userDTO.Name, userDTO.Email);
            if (user == null)
            {
                user = mapper.Map<User>(userDTO);

                userDAL.Insert(user);
                //Enviar email
                return true;
            }
            return false;
        }

        public UserBL(IUserDAL userDAL, IMapper mapper)
        {
            this.userDAL = userDAL;
            this.mapper = mapper;
        }

        public UserDTO? GetUser(string Name, string Email)
        {
            var user = userDAL.GetUser(Name, Email);
            if (user != null)
            {
                var userDTO = mapper.Map<UserDTO>(user);
                return userDTO;
            }
            else
            {
                return null;
            }
        }

        public List<UserDTO> GetUsers()
        {
            var users = userDAL.GetUsers();
            var userDTOs = mapper.Map<List<UserDTO>>(users);
            return userDTOs;
        }
    }
}
