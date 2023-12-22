namespace WebApi.MinimalApi
{
    public static class AlertMap
    {
        public static IEndpointRouteBuilder MapAlerts(this IEndpointRouteBuilder builder)
        {
            var groupBuilder = builder.MapGroup("Api");
            groupBuilder.MapGet("/alerts", EndPointBorrowingAlertView.GetAlerts);
            return builder;
        }
    }
}
