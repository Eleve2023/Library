namespace Domain.Exceptions
{
    public class LibraryCardNotFoundException(int id) : Exception($"No item found with id {id}")
    {
    }
}
