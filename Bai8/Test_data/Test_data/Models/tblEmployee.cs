namespace Test_data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployee")]
    public partial class tblEmployee
    {
        [Key]
        public int eid { get; set; }
        [DisplayName("H? tên")]
        [StringLength(30)]
        public string name { get; set; }

        [DisplayName("Tu?i")]

        public int? age { get; set; }

        [StringLength(30)]
        public string addr { get; set; }

        public int? salary { get; set; }

        [StringLength(50)]
        public string image { get; set; }

        public int? deptid { get; set; }

        public virtual tblDept tblDept { get; set; }
    }
}
