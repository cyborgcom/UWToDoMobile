namespace UWToDoMobile.Services
{
    public static class ServicesExtensions
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IToDoListService, ToDoListService>();

            return builder;
        }
    }
}
