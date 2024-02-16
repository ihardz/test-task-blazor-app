using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.State
{
    public class StateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string Abbreviation { get; set; }
    }
}
