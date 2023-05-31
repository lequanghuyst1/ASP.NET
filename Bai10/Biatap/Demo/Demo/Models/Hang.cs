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
        [DisplayName("M� H�ng")]
        [StringLength(100)]
        public string MaHang { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        [Required]
        [DisplayName("T�n H�ng")]
        [StringLength(255)]
        public string TenHang { get; set; }
        [DisplayName("Gi�")]

        public decimal? Gia { get; set; }

        public decimal LuongCo { get; set; }

        [StringLength(1000)]
        public string MoTa { get; set; }

        public decimal? ChietKhau { get; set; }

        [DisplayName("H�nh anh")]
        [StringLength(100)]
        

        public string HinhAnh { get; set; }

        public virtual Nha_CC Nha_CC { get; set; }
    }
}
