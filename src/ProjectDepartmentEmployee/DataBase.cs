﻿using System.Data.Entity;
using ProjectDepartmentEmployee.Class;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace ProjectDepartmentEmployee
{
    class DataBase : DbContext
    {
        public DataBase() :
        base("TestDB")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().ToTable("Empoyee");
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


    }
}
