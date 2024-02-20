using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class WindowDto : WindowUpsertDto
    {
        public int Id { get; set; }
        public int TotalSubElements { get; set; }

        [Required]
        public IEnumerable<SubElementDto> SubElements { get; set; }
    }
}
