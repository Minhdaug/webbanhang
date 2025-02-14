using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace WebBanHangOnline.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Tên khách hàng không để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không để trống")]
        [RegularExpression(@"^0[35789]\d{8}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng 0 và theo sau là 3, 5, 7, 8, hoặc 9, rồi đến 8 số ngẫu nhiên.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ khổng để trống")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email không để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        public int TypePayment { get; set; }
        public int TypePaymentVN { get; set; }
    }
}