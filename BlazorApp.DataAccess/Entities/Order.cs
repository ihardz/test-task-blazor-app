using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataAccess.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
}
