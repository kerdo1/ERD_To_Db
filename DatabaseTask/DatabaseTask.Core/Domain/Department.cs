using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Department
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Department_Id { get; set; }

		[Required]
		[ForeignKey("Branch_Office")]
		public int Branch_Office_Id { get; set; }
		public Branch_Office Branch_Office { get; set; }

		[Required]
		[StringLength(100)]
		public string Address { get; set; }

		[Required]
		[StringLength(20)]
		public string Contact_Person { get; set; }

		[Required]
		public int Contact_Phonenumber { get; set; }

		[Required]
		[StringLength(30)]
		public string Contact_Email { get; set; }

		[StringLength(100)]
		public string? Comment { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}	