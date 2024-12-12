using CameraScanner.Maui;

namespace UWToDoMobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                    fonts.AddFont("OpenSans-Italic.ttf", "OpenSansItalic");
                    fonts.AddFont("OpenSans-BoldItalic.ttf", "OpenSansBoldItalic");
                })
                .ConfigureViewModels()
                .ConfigureViews()
                .ConfigureServices()
                .UseCameraScanner();
#if DEBUG
            builder.Logging.AddDebug();
#endif                     
            MauiApp app = builder.Build();

            return app;
        }
    }
}
