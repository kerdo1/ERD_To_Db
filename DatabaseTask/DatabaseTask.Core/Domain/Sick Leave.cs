using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Sick_Leave
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Sick_Leave_Id { get; set; }

		[ForeignKey("Employee")]
		[Required]
		public int Employee_Id { get; set; }
		public Employee Employee { get; set; }

		[Required]
		public DateTime Stard_Date { get; set; }
		
		[Required]
		public DateTime End_Date { get; set; }

		[StringLength(100)]
		public string? Comment { get; set; }
	}
}
