namespace Domain.Exceptions
{
    public class WorkDomainNotFoundException(int id) : Exception($"No item found with id {id}")
    {
    }
}
