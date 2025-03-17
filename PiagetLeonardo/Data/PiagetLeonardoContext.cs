using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PiagetLeonardo.Models;

namespace PiagetLeonardo.Data
{
    public class PiagetLeonardoContext : DbContext
    {
        public PiagetLeonardoContext (DbContextOptions<PiagetLeonardoContext> options)
            : base(options)
        {
        }

        public DbSet<PiagetLeonardo.Models.Aluno> Aluno { get; set; } = default!;
    }
}
