namespace MyStoreApi.Extensions;

public static class WebApplicationBuilderExtension
{
    public static void AddPresentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(options =>
            options.AddDefaultPolicy(cpb =>
            {
                cpb.AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .WithOrigins(builder.Configuration.GetValue<string>("MyStoreBaseUrl")!);
            }
         ));

        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
    }
}
