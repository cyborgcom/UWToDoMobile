namespace UWToDoMobile.ViewModels
{
    public partial class ViewModelBase : ObservableObject
    {
        public ViewModelBase()
        {
        }

        [ObservableProperty]
        private string _title = string.Empty;

        public static Task HandleExceptionAsync(Exception ex, string message, string title)
        {
            Console.WriteLine($"{title}:{message} {ex.Message}");
            return Task.CompletedTask;
        }

        public virtual async Task LoadData()
        {
            await Task.CompletedTask;
        }
    }
}
