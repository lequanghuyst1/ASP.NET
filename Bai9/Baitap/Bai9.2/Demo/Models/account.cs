namespace Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Không ???c ?? tr?ng!")]
        [DisplayName("Tên ng??i dùng")]
        [StringLength(50)]
        public string username { get; set; }

        [Required(ErrorMessage = "Không ???c ?? tr?ng!")]
        [DisplayName("H? tên")]
        [StringLength(30)]
        public string fullname { get; set; }

        [Required]
        [DisplayName("?i?n tho?i")]
        [StringLength(20)]
        public string phone { get; set; }

        [Required]
        [DisplayName("M?t kh?u")]
        [StringLength(30)]
        public string password { get; set; }

        [StringLength(50)]
        [DisplayName("Email")]
        public string email { get; set; }
    }
}
