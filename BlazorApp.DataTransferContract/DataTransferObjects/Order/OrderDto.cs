using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class OrderDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public StateDto State  { get; set; }
    }
}
