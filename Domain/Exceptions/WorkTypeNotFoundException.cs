namespace Domain.Exceptions
{
    public class WorkTypeNotFoundException(object id) : Exception($"No item found with id {id}")
    {
    }
}
