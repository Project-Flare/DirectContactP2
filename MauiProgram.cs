using Microsoft.Extensions.Logging;
using Project.Views;
using Project.Views.ViewModel;

namespace Project
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<CurrentContactPage>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<NewContactPage>();

            return builder.Build();
        }
    }
}
