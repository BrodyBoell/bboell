using System.ComponentModel.DataAnnotations;
namespace ResponsiveWebApp.Models
{
	public class AgeThisYear
	{
		//input validation
		[Required(ErrorMessage = "Please enter a Name.")]
		[RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage ="Entry must be Full Name")]
		public String? Name { get; set; }
		//input validation
		[Required(ErrorMessage = "Please enter a Birth Year.")]
		[Range(1900, 2100, ErrorMessage = "Enter a Birth Year between 1900 and 2100.")]
		public int? BirthYear { get; set; }
		public String? currentAge { get; set; }
		//Method to find age
		public int? ageThisYear()
		{
			int? year = 2024;
			 int? currentAge = year - BirthYear;
			
			return currentAge;
		}
		//Method to print message of how old someone will be on December 31st

		public string? Output()
		{
			
			string? print = Convert.ToString(Name + " will be " + currentAge + " On December 31st");
			return print;
		}
	}
}
