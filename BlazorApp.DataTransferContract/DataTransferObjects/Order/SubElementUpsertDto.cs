using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class SubElementUpsertDto
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int Element { get; set; }
        [Required]
        public int TypeId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Width { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Height { get; set; }
        [Required]
        public int WindowId { get; set; }
    }
}
