namespace Demo.Models
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

        [Required(ErrorMessage ="Không ???c ?? tr?ng")]
        [DisplayName("H? tên")]
        [StringLength(30)]
        public string name { get; set; }

        [Required(ErrorMessage = "Không ???c ?? tr?ng")]
        [DisplayName("Tu?i")]
        public int? age { get; set; }

        [Required(ErrorMessage = "Không ???c ?? tr?ng")]
        [DisplayName("??a ch?")]
        [StringLength(30)]
        public string addr { get; set; }

        [Required(ErrorMessage = "Không ???c ?? tr?ng")]
        [DisplayName("L??ng")]
        public int? salary { get; set; }
        
        
        [DisplayName("Link ?nh")]
        [StringLength(50)]
        public string image { get; set; }

        [DisplayName("Phòng ban")]
        public int? deptid { get; set; }

        public virtual tblDept tblDept { get; set; }
    }
}
