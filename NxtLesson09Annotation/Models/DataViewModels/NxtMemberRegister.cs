using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NxtLesson09Annotation.Models.DataViewModels
{
    public class NxtMemberRegister
    {
        [DisplayName("Tên đăng nhập ")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống ")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoảng 2- 20 ký tự  ")]
        public int NxtMemberId { get; set; }
        
        [DisplayName("Họ và tên  ")]
        [Required(ErrorMessage = "Họ tên không được để trống ")]
        [DataType(DataType.Password)]
        public string NxtUserName { get; set; }
       
        [DisplayName(" Mật Khẩu ")]
        [Required(ErrorMessage = "Hãy Nhập Mật khẩu")]
        [DataType(DataType.Password)]
        public string NxtPassword { get; set; }
        
        [DisplayName(" Hòm thư  ")]
        [Required(ErrorMessage = "Email không được bỏ trống ")]
        [DataType(DataType.EmailAddress)]
        public string NxtEmail { get; set; }
        
        [DisplayName(" Điện thoại   ")]
        [RegularExpression(@"^0\d{9,12}$",ErrorMessage = "Phải bắt đầu bằng 0 và dài 10-12 số ")]
        public string NxtPhoneNumber { get; set; }
        
        [DisplayName("Tên đầy đủ  ")]
        [Required(ErrorMessage = "Tên đầy đủ  không được để trống ")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên có độ dài trong khoảng 2- 20 ký tự  ")]
        public string NxtFullName { get; set; }
        
        [DisplayName(" Ngày sinh   ")]
        [Required(ErrorMessage = "Ngày sinh không được bỏ trống ")]
        [DataType(DataType.Date)]
        public DateTime NxtBirthday { get; set; }
       
    }
}
