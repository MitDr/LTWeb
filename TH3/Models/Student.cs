using System.ComponentModel.DataAnnotations;

namespace TH1.Models
{
	public class Student
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Tên bắt buộc phải được nhập!!")]
		[Display(Name = "Họ tên")]
		[RegularExpression("^[A-Za-z]{4, 100}$",ErrorMessage = "Sai định dạng rồi")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Email bắt buộc phải được nhập!!")]
		[RegularExpression("^[A-Za-z0-9._%+-]+@gmail\\.com$", ErrorMessage = "email phải có @gmail.com")]
		//[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "email phải có @gmail.com")]
		public string? Email { get; set; }
		[Display(Name = "Mật khẩu")]
		[RegularExpression("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[@#$%^&+=!.]).{8,}$", ErrorMessage = "sai yêu cầu")]
		[StringLength(100,MinimumLength =8)]
		[Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập!!")]
		public string? Password { get; set; }
		[Required(ErrorMessage = "Hãy chọn chuyên ngành!!")]
		[Display(Name = "Chuyên ngành")]

		public Branch? Branch { get; set; }
		[Display(Name = "Giới tính")]

		[Required(ErrorMessage = "Giới tính phải được chọn!!")]
		public Gender? Gender { get; set; }
		[Display(Name = "Là người quen?")]

		public bool IsRegular { get; set; }
		[Display(Name = "Địa chỉ")]

		[Required(ErrorMessage ="Địa chỉ phải được nhập!!")]
		[DataType(DataType.MultilineText)]
        public string? Address { get; set; }
		[Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime),"1/1/1963","12/31/2005", ErrorMessage = "ngày sinh phải nằm trong khoảng từ 1/1/1963 đến 31/12/2005.")]
		[DataType(DataType.DateTime, ErrorMessage = "Nhập sai kiểu rồi")]
		[Required(ErrorMessage = "Ngày sinh phải được nhập")]
		public DateTime DateOfBirth { get; set; }
		[Required(ErrorMessage = "Điểm bắt buộc phải nhập")]
		[Range(0.0, 10.0, ErrorMessage = "Giá trị phải nằm trong khoảng từ 0.0 đến 10.0.")]
		[Display(Name ="Điểm")]
		public double? Mark {  get; set; }

    }
}
