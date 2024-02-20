using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class WindowUpsertDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int OrderId { get; set; }
    }
}
