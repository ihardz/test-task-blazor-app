using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataAccess.Entities
{
    [Index(nameof(Element), nameof(WindowId), IsUnique = true, Name = "IX_Element_WindowId_Unique")]
    public class SubElement
    {
        public int Id { get; set; }
        public int Element { get; set; }
        public int TypeId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int WindowId { get; set; }

        [Required]
        public virtual SubElementType Type { get; set; }
    }
}
