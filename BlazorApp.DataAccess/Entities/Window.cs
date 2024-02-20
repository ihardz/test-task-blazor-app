using BlazorApp.DataAccess.Entities.Abstraction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.DataAccess.Entities
{
    public class Window : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [NotMapped]
        public int TotalSubElements { get; set; }
        public int OrderId { get; set; }
        [Required]
        public virtual ICollection<SubElement> SubElements { get; set; }
    }
}
