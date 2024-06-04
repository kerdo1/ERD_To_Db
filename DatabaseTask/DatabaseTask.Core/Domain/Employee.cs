using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Employee_Id { get; set; }

		[Required]
		[StringLength(20)]
		public string First_Name { get; set; }

		[Required]
		[StringLength(20)]
		public string Last_Name { get; set; }

		[Required]
		public int Personal_Idendification_Number { get; set; }

		[Required]
		[StringLength(100)]
		public string Contact_Address { get; set; }

		[Required]
		public int Contact_Phonenumber { get; set; }

		[Required]
		[StringLength(30)]
		public string Contact_Email { get; set; }

		[Required]
		public DateTime At_Work_Since { get; set; }

		[Required]
		public DateTime At_Work_Until { get; set; }

		public Work_time Work_time { get; set; }

		[Required]
		[ForeignKey("Access_Level")]
		public int Access_Level_Id { get; set; }
		public Access_Level Access_Level { get; set; }

		[Required]
		public int Salary { get; set; }

		[StringLength(100)]
		public string Comment { get; set; }

		public ICollection<Borrowed_Item> Borrowed_Items { get; set; }
		public ICollection<Employees_Child> Employees_Child { get; set; }
		public ICollection<Request> Requests { get; set; }
		public ICollection<Health_Check> Health_Checks { get; set; }
		public ICollection<Sick_Leave> Sick_Leaves { get; set; }
		public ICollection<Vacation> Vacations { get; set; }
		public Department Department { get; set; }
	}
}