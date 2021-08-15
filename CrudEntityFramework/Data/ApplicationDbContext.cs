using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Data
{
    
    public class ApplicationDbContext : DbContext
    {

        //constructor 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }//end constructor

        //hacemos un llamado a nuestro modelo usuario
        public DbSet<Models.Usuario> Usuario { get; set; }
    }
}
