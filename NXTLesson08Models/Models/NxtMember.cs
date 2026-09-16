using System.ComponentModel;

namespace NXTLesson08Models.Models
{
    public class NxtMember
    {
        public string NxtMemberId {  get; set; }
        public string NxtUserName { get; set; }
        public string NxtPassword { get; set; }
        [DisplayName("Họ và tên")]
        public string NxtFullName { get; set; }
        public string NxtEmail { get; set; }

    }
}
