using DataAccess.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ContextDB : DbContext
    {
        private readonly IConfiguration _configuration;

        public ContextDB(DbContextOptions<ContextDB> options, IConfiguration configuration) : base(options)
        {
            this._configuration = configuration;
        }

        public ContextDB()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(
                _configuration.GetConnectionString("BDConnetion"),
                opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(2).TotalSeconds)
                );
        }


        public DbSet<OFFICE> OFFICE { get; set; }
        public DbSet<DIVISION> DIVISION { get; set; }
        public DbSet<POSITION> POSITION { get; set; }
        public DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public DbSet<SALARY> SALARY { get; set; } 
        //
    }
}
