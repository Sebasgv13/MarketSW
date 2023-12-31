﻿using Microsoft.EntityFrameworkCore;
using Market.Shared.Entities;
namespace Market.API.Data
{
    public class DataContext : DbContext
    {
        //Utilizar  las propiedades y opciones de DBContext
        public DataContext(DbContextOptions<DataContext> options) : base(options) {


        }
        public DbSet<Country>Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
