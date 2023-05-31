using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Test_data.Models
{
    public partial class EmployeeDB : DbContext
    {
        public EmployeeDB()
            : base("name=EmployeeDB")
        {
        }

        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
