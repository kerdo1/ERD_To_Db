using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Health_Check
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Health_Check_Id	 { get; set; }

		[ForeignKey("Employee")]
		[Required]
		public int Employee_Id { get; set; }
		public Employee Employee { get; set; }

		[Required]
		public DateTime DeDatescription { get; set; }

		[Required]
		[StringLength(300)]
		public string Result { get; set; }

		[StringLength(100)]
		public string? Comment { get; set; }
	}
}