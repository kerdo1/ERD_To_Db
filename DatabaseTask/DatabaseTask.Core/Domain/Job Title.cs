using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
	public class Job_Title
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Job_TitleId { get; set; }

		[Required]
		[StringLength(30)]
		public string Title { get; set; }

		[Required]
		[StringLength(30)]
		public string Description { get; set; }

		[Required]
		public int Salary_level { get; set; }

		[StringLength(100)]
		public string Comment { get; set; }

		public ICollection<Work_time> Work_time { get; set; }

	}
}
