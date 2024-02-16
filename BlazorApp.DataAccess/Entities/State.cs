using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.DataAccess.Entities
{
    //  migrationBuilder.InsertData("States", nameof(State.Abbreviation), MigrationsData.StatesAbbreviations.ToArray());
    [Index(nameof(Abbreviation), IsUnique = true)]
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(2)")]
        public string Abbreviation { get; set; }
    }
}
