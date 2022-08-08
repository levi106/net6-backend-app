namespace Net6BackendApp;

public static class ApiModule
{
    public static IEndpointRouteBuilder MapApiRoutes(this WebApplication app)
    {
        app.MapGet("api/v1/gc", () =>
        {
            app.Logger.LogInformation("gc");
            GC.Collect();
            return "Ok";
        })
        .Produces<string>()
        .WithName("GC");

        return app;
    }
}
