using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bai8._3.Models
{
    public class account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [Required(ErrorMessage ="Không được để trống!")]
        [StringLength(50)]
        [DisplayName("Tên người dùng")]
        public string username { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Họ tên")]
        public string fullname { get; set; }
        [DisplayName("Số điện thoại")]
        public string phone { get; set; }
        [DisplayName("Mật khẩu")]
        public string password { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }


    }
}