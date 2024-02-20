using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class SubElementDto : SubElementUpsertDto
    {
        public int Id { get; set; }        
    }
}
