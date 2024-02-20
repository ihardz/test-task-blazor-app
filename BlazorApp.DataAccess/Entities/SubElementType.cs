using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BlazorApp.DataAccess.Entities.Abstraction;

namespace BlazorApp.DataAccess.Entities
{
    [Index(nameof(Name), IsUnique = true, Name = "IX_Name_Unique")]
    public class SubElementType : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
    }
}
