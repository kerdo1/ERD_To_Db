using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Work_time
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Work_TimeId { get; set; }

		[ForeignKey("Employee")]
		[Required]
		public int Employee_Id { get; set; }
		public Employee Employee { get; set; }

		[ForeignKey("Job_Title")]
		[Required]
		public int Job_Title_Id { get; set; }
		public Job_Title Job_Title { get; set; }

		[Required]
		public DateTime Starting_Date { get; set; }
		[Required]
		public DateTime Ening_Date { get; set; }


		[StringLength(100)]
		public string Comment { get; set; }
		
	}
}
