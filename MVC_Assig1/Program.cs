namespace MVC_Assig1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/welcome", async context =>
            {
                await context.Response.WriteAsync("welcome asp .net");
            });
            app.Run();
        }
    }
}
