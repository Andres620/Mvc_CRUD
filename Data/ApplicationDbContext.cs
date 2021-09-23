using MvcCRUD_MDC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCRUD_MDC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Medico> Medico { get; set; }

    }
}