using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoListEvaluacion.Models;

namespace TodoListEvaluacion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Prioridad>? Prioridads { get; set; }
        public virtual DbSet<Tarea> Tareas { get; set; }

       
    }
}
