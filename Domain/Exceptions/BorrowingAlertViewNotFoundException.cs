namespace Domain.Exceptions
{
    public class BorrowingAlertViewNotFoundException(object id) : Exception($"No item found with id {id}")
    {
    }
}
