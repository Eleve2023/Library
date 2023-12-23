using Application.Services;

namespace WebApi.MinimalApi
{
    public static class EndPointBorrowingAlertView
    {
        public static async Task<IResult> GetAlerts(BorrowingAlertViewService borrowingService)
        {
            return TypedResults.Ok(await borrowingService.GetAsync());
        }
    }
}
