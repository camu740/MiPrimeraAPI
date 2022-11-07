using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL
{
    public class TareaContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<User> Users { get; set; }

        protected readonly IConfiguration Configuration;

        public TareaContext() {}

        public TareaContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("server=localhost;port=3306;database=apitarea;user=user;password=P@ssw0rd;", 
                ServerVersion.AutoDetect("server=localhost;port=3306;database=apitarea;user=user;password=P@ssw0rd;"));
        }
    }
}
