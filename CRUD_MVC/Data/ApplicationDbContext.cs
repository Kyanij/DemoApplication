using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_MVC.Models;

public class ApplicationDbContext : DbContext
    {
    public DbSet<Product> Product { get; set; } = default!;
    public DbSet<Employee> Employee { get; set; } = default!;
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
    }
