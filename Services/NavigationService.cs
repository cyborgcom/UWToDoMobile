namespace UWToDoMobile.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToBarCodeScannerAsync(bool animate = true)
        {
            await NavigateAsync("///BarCodeScannerView", animate);
        }

        public async Task NavigateToToDoListAsync(bool animate = true)
        {
            await NavigateAsync("///ToDoListView", animate);
        }

        private async Task NavigateAsync(string state, bool animate = true, IDictionary<string, object>? parameters = null)
        {
            if (!string.IsNullOrWhiteSpace(state) && parameters?.Any() == true)
            {
                await Shell.Current.GoToAsync(state, animate, parameters);
            }
            else
            {
                await Shell.Current.GoToAsync(state, animate);
            }
        }
    }
}
