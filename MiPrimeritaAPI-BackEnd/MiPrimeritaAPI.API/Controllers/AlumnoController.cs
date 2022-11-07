using Microsoft.AspNetCore.Mvc;
using MiPrimeritaAPI.BL.Contracts;
using MiPrimeritaAPI.BL.Implementations;
using MiPrimeritaAPI.CORE.DTO;

namespace MiPrimeritaAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        public IAlumnoBL alumnoBL { get; set; }

        public AlumnoController(IAlumnoBL alumnoBL)
        {
            this.alumnoBL = alumnoBL;
        }

        [HttpGet("All")]
        public ActionResult<List<AlumnoDTO>> GetAlumnos()
        {
            return Ok(alumnoBL.GetAlumnos());
        }

        [HttpGet]
        public ActionResult<AlumnoDTO?> GetAlumno(string DNI)
        {
            var alumno = alumnoBL.GetAlumno(DNI);
            if (alumno != null)
                return Ok(alumno);
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult Insert(AlumnoDTO a)
        {
            if (alumnoBL.Insert(a))
                return Ok();
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<AlumnoDTO?> Update(AlumnoDTO alumno)
        {
            alumnoBL.Update(alumno);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(string DNI)
        {
            alumnoBL.Delete(DNI);
            return Ok();
        }

    }
}