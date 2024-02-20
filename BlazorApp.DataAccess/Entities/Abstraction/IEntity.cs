namespace BlazorApp.DataAccess.Entities.Abstraction
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
