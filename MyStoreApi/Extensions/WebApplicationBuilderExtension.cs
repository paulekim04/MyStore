namespace MyStoreApi.Extensions;

public static class WebApplicationBuilderExtension
{
    public static void AddPresentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
    }
}
