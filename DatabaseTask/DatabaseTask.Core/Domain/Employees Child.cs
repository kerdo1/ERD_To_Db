using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Employees_Child
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Employees_Child_Id { get; set; }

		[ForeignKey("Employee")]
		[Required]
		public int Employee_Id { get; set; }
		public Employee Employee { get; set; }

		[Required]
		[StringLength (20)]
		public string First_Name { get; set; }

		[Required]
		[StringLength(20)]
		public string Last_Name { get; set; }
		[Required]
		public int Age { get; set; }


		[StringLength(100)]
		public string Comment { get; set; }

	}
}