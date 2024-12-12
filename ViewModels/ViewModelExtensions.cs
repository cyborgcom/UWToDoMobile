namespace UWToDoMobile.ViewModels
{
    public static class ViewModelExtensions
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<ToDoListViewModel>();
            builder.Services.AddSingleton<BarCodeScannerViewModel>();

            return builder;
        }
    }
}
