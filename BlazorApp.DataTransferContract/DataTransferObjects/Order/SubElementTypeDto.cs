using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class SubElementTypeDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
