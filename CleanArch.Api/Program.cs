using VideoJuegos.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace Humans.Payroll.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            //Serilog.Debugging.SelfLog.Enable(msg => Debug.WriteLine(msg));
            //Log.CloseAndFlush();
            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom
            //    .Configuration(configuration)
            //    .CreateLogger();


            //Log.Logger = new LoggerConfiguration()
            //.WriteTo
            //.MSSqlServer(
            //    connectionString: "Server=U25TEC-CRISTIAN;Database=HumansIdentityDev; Integrated Security=false;User ID=sa; Password=CFX2017cc;MultipleActiveResultSets=True;",
            //    sinkOptions: new MSSqlServerSinkOptions { TableName = "EventsLogs" })
            //.WriteTo
            //.Console()

            //.CreateLogger();


            Log.Logger = new LoggerConfiguration()
           .Enrich.FromLogContext()
           .ReadFrom.Configuration(configuration)
           .WriteTo.Console()
           .CreateLogger();

            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception exception)
            {
                Log.Fatal(exception, "Error starting");
            }
            finally
            {
                Log.CloseAndFlush();
            }


       
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseSerilog((hostingContext, services, loggerConfiguration) => loggerConfiguration
           .ReadFrom.Configuration(hostingContext.Configuration)
           .Enrich.FromLogContext()
           .WriteTo.Console());
    }
}
