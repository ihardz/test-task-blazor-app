﻿using BlazorApp.DataAccess.Entities.Abstraction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataAccess.Entities
{
    public class Order : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int StateId { get; set; }

        public virtual State State { get; set; }
        [Required]
        public virtual IEnumerable<Window> Windows { get; set; }

    }
}
