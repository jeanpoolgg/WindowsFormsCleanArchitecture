using Microsoft.Extensions.DependencyInjection;

namespace WindowsFormsCleanArchitecture
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            // Application.Run(new FormMain());

            var formMain = serviceProvider.GetRequiredService<FormMain>();
            Application.Run(formMain);

        }


        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<FormMain>();
            services.AddTransient<FormBrand>();
        }
    }
}