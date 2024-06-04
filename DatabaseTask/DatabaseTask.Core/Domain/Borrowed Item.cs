using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Borrowed_Item
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Borrowed_Item_Id { get; set; }

		[ForeignKey("Employee")]
		[Required]
		public int Employee_Id { get; set; }
		public Employee Employee { get; set; }

		[Required]
		[StringLength (30)]
		public int Item_Name { get; set; }

		[Required]
		public DateTime Borrow_Date { get; set; }
		[Required]
		public DateTime Return_Date { get; set; }


		[StringLength(100)]
		public string Comment { get; set; }

	}
}