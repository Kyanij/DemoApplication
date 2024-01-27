using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

    public class MyApplicationDbContext : DbContext
    {
        public MyApplicationDbContext (DbContextOptions<MyApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!; //Entity
        public DbSet<RegisterUser> User { get; set; } = default!; //Entity
}
