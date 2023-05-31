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

        [Required(ErrorMessage ="Kh�ng ???c ?? tr?ng!")]
        [DisplayName("T�n ng??i d�ng")]
        [StringLength(50)]
        public string username { get; set; }

        [Required(ErrorMessage = "Kh�ng ???c ?? tr?ng!")]
        [DisplayName("H? t�n")]
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
