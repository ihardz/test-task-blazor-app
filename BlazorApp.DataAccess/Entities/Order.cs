using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.DataAccess.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [ForeignKey("FK_Order_State")]
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}
