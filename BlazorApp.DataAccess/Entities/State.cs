using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.DataAccess.Entities
{
    [Index(nameof(Abbreviation), IsUnique = true, Name = "IX_Abbreviation_Unique")]
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(2)")]
        public string Abbreviation { get; set; }
    }
}
