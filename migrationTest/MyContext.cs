using Microsoft.EntityFrameworkCore;
using migrationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace migrationTest
{
    public class MyContext : DbContext
    {

        public DbSet<Phone> Phones { get; set; }
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }
    }
}
