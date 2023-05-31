using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Demo.Models
{
    public partial class EmployeeDb : DbContext
    {
        public EmployeeDb()
            : base("name=EmployeeDb")
        {
        }

        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
