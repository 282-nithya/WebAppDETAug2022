using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ODataDemo.Model;

namespace ODataDemo.Data
{
    public class ODataDemoContext : DbContext
    {
        public ODataDemoContext (DbContextOptions<ODataDemoContext> options)
            : base(options)
        {
        }

        public DbSet<ODataDemo.Model.student> student { get; set; } = default!;
    }
}
