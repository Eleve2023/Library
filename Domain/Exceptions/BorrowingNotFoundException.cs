namespace Domain.Exceptions
{
    public class BorrowingNotFoundException(int id) : Exception($"No item found with id {id}")
    {
    }
}
