namespace MVC_Assig1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            #region notes
            //Asp.Net hve 3 project 1-web app 2 razor pages 3- web api
            //web app use mvc design pattern
            // rszor pages used for small projects
            //web api used to build RESTful services
            //mvc design pattern contain 3 main component 1-model 2-view 3-controller
            //model : class to represent data in database
            //view : html page to display data to user
            //controller : class that inherit from controller base and process user request and interact with model and return view
            // methon in class controller called action
            //method in api controller called endpoint
            //100 =>199 => informational
            //200 =>299 => success
            //300 =>399 => redirection
            //400 =>499 => client error
            //500 =>599 => server error
            // the flow of request in mvc
            // app stating program class => startup class => configure service  => pipline is created => ready for request 
            #endregion
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/welcome", async context =>
            {
                await context.Response.WriteAsync("welcome asp .net");
            });
            app.MapGet("/youssef", async context =>
            {
                await context.Response.WriteAsync("welcome youssef");
            });
            app.Run();
        }
    }
}
