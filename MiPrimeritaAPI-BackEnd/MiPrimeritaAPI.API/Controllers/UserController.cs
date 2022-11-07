using Microsoft.AspNetCore.Mvc;
using MiPrimeritaAPI.BL.Contracts;
using MiPrimeritaAPI.BL.Implementations;
using MiPrimeritaAPI.CORE.DTO;
namespace MiPrimeritaAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserBL userBL { get; set; }

        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult Login(LoginDTO loginDTO)
        {
            var users = userBL.GetUsers();
            foreach (var user in users)
            {
                if(user.Name == loginDTO.User)
                {
                    if(user.Passwd == loginDTO.Password)
                        return Ok();
                    return BadRequest();

                }
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("Register")]
        public ActionResult Register(UserDTO userDTO)
        {
            if (userBL.Insert(userDTO))
                return Ok();
            return BadRequest();
        }

    }
}
