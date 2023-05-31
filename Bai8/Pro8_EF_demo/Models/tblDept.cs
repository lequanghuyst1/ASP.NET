namespace Pro8_EF_demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDept")]
    public partial class tblDept
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDept()
        {
            tblEmployees = new HashSet<tblEmployee>();
        }

        [Key]
        [DisplayName("Mã phòng ban")]
        public int deptid { get; set; }

        [Required]
        [StringLength(25)]
        [DisplayName("Phòng ban")]
        public string deptname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
