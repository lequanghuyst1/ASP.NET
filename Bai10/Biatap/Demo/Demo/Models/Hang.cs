namespace Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hang")]
    public partial class Hang
    {
        [Key]
        [DisplayName("Mã Hàng")]
        [StringLength(100)]
        public string MaHang { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        [Required]
        [DisplayName("Tên Hàng")]
        [StringLength(255)]
        public string TenHang { get; set; }
        [DisplayName("Giá")]

        public decimal? Gia { get; set; }

        public decimal LuongCo { get; set; }

        [StringLength(1000)]
        public string MoTa { get; set; }

        public decimal? ChietKhau { get; set; }

        [DisplayName("Hình anh")]
        [StringLength(100)]
        

        public string HinhAnh { get; set; }

        public virtual Nha_CC Nha_CC { get; set; }
    }
}
