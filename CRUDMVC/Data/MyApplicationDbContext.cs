using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDMVC.Models;

    public class MyApplicationDbContext : DbContext
    {
    public DbSet<Employee> Employee { get; set; } = default!;

    public MyApplicationDbContext (DbContextOptions<MyApplicationDbContext> options)
            : base(options)
        {
        }

       
}
