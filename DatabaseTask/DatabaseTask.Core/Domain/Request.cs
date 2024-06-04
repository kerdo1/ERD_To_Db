using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Request
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Request_Id { get; set; }

		[Required]
		[StringLength(30)]
		public string Topic { get; set; }

		[Required]
		[StringLength(300)]
		public string Description { get; set; }

		[ForeignKey("Employee")]
		[Required]
		public int Employee_Id { get; set; }
		public Employee Employee { get; set; }

		[Required]
		[StringLength(30)]
		public string State { get; set; }

		[Required]
		[StringLength(30)]
		public string Recipient { get; set; }

		[StringLength(100)]
		public string Comment { get; set; }

	}
}