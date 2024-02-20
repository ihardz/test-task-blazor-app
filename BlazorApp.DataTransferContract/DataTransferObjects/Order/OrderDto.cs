using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorApp.DataTransferContract.DataTransferObjects.Order
{
    public class OrderDto : OrderUpsertDto
    {
        public int Id { get; set; }
        public StateDto State  { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IEnumerable<WindowDto> Windows { get; set; }
    }
}
