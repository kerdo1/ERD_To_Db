using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Company
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Company_Id { get; set; }

		[Required]
		public int Registry_Number { get; set; }

		[Required]
		[StringLength(20)]
		public string Name { get; set; }

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

		public ICollection<Branch_Office> Branch_Offices { get; set; }

	}
}

