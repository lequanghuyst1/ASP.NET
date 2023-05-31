namespace Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [Key]
        public int proid { get; set; }

        [Required(ErrorMessage ="Không ???c ?? tr?ng!")]
        [StringLength(45)]
        [DisplayName("Tên s?n ph?m")]
        public string proname { get; set; }

        [DisplayName("Giá")]
        public decimal price { get; set; }

        public decimal stock { get; set; }

        [StringLength(100)]
        [DisplayName("Hình ?nh")]
        public string image { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public int catid { get; set; }

        public virtual category category { get; set; }
    }
}
