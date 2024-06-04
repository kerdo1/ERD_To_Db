using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Access_Level
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Access_Level_Id { get; set; }

		[Required]
		public int Level { get; set; }

		[Required]
		[StringLength(30)]
		public string Description { get; set; }

		[Required]
		[StringLength(30)]
		public string Access_Type { get; set; }

		[StringLength(100)]
		public string? Comment { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}