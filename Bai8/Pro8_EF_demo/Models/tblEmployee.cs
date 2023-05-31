namespace Pro8_EF_demo.Models
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

        [Required(ErrorMessage ="Bạn phải nhập dữ liệu!")]
        [DisplayName("Họ tên")]
        [StringLength(30)]
        
        public string name { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập dữ liệu!")]
        [DisplayName("Tuổi")]
        public int age { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập dữ liệu!")]
        [DisplayName("Địa chỉ")]
        [StringLength(30)]
        public string addr { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập dữ liệu!")]
        [DisplayName("Lương")]
        public int salary { get; set; }

        
        [DisplayName("Link ảnh")]
        [StringLength(50)]
        public string image { get; set; }

        [DisplayName("Phòng ban")]
        public int? deptid { get; set; }

        public virtual tblDept tblDept { get; set; }
    }
}
