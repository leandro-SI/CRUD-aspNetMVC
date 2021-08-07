﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(DESKTOP-6CICVVM\SQLEXPRESS)\mssqllocaldb;Database=Crudmvc;Integrated Security=True");
        }
    }
}
