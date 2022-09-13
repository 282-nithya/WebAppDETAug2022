using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIWeb.Models;

namespace APIWeb.Data
{
    public class APIWebContext : DbContext
    {
        public APIWebContext (DbContextOptions<APIWebContext> options)
            : base(options)
        {
        }

        public DbSet<APIWeb.Models.User> User { get; set; } = default!;

        public DbSet<APIWeb.Models.TodoItem>? TodoItem { get; set; }
    }
}
