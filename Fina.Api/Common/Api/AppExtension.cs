namespace Fina.Api.Common.Api
{
    public static class AppExtension
    {
        public static void ConfigureDevEnviroment(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            // Caso queira usar auth no swagger
            // app.MapSwagger().RequireAuthorization();
        }
    }
}
