namespace Domain.Exceptions
{
    public class WorkNotFoundException(int id) : Exception($"No item found with id {id}")
    {
    }
}
