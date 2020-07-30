﻿using System;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class CursosOnlineContext : DbContext
    {
        public DbSet<Comentario> Comentario { get; set;}
        public DbSet<Curso> Curso { get; set;}
        public DbSet<CursoInstructor> CursoInstructor { get; set;}
        public DbSet<Instructor> Instructor { get; set;}
        public DbSet<Precio> Precio { get; set;}
        
        

        public CursosOnlineContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new { ci.InstructorId, ci.CursoId });
        }
    }
}
