using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class OrderUpsertDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int StateId { get; set; }
    }
}
