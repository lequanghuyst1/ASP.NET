namespace BaiTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [Key]
        public int Mavd { get; set; }

        [Required(ErrorMessage = "Khong duoc de trong")]
        [StringLength(100)]
        public string Tenvd { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Khong duoc de trong")]

        public string Mota { get; set; }

        [Required(ErrorMessage = "Khong duoc de trong")]

        [StringLength(250)]
        public string TenAnh { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong")]

        public decimal Giatien { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong")]

        public int? Soluong { get; set; }

        public int MaDanhmuc { get; set; }

        public virtual Danhmuc Danhmuc { get; set; }
    }
}
