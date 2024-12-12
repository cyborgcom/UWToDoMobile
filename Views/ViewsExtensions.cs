namespace UWToDoMobile.Views
{
    public static class ViewsExtensions
    {
        public static MauiAppBuilder ConfigureViews(this MauiAppBuilder builder)
        {            
            builder.Services.AddSingleton<ToDoListView>();
            builder.Services.AddSingleton<BarCodeScannerView>();

            return builder;
        }
    }

}
