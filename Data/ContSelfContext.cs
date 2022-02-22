#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContSelf.Models;

namespace ContSelf.Data{
    public class ContSelfContext : DbContext
    {
        public ContSelfContext (DbContextOptions<ContSelfContext> options)
            : base(options)
        {
        }

        public DbSet<ContSelf.Models.Funcionario> Funcionario { get; set; }
    }
}