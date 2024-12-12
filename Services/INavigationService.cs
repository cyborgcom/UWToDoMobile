namespace UWToDoMobile.Services
{
    public interface INavigationService
    {
        Task NavigateToToDoListAsync(bool animate = true);
        Task NavigateToBarCodeScannerAsync(bool animate = true);
    }
}
