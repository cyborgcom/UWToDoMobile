using CameraScanner.Maui;
using CommunityToolkit.Mvvm.Input;

namespace UWToDoMobile.ViewModels
{
    public partial class BarCodeScannerViewModel : ViewModelBase
    {
        private IAsyncRelayCommand<BarcodeResult[]> onDetectionFinishedCommand;
        private readonly INavigationService NavigationService;

        public BarCodeScannerViewModel(INavigationService navigationService)
        {
            this.onDetectionFinishedCommand = new AsyncRelayCommand<BarcodeResult[]>(HandleScanResultAsync);
            NavigationService = navigationService;
        }

        [RelayCommand]
        private async Task BarcodeResultTapped(object sender)
        {
            await Task.CompletedTask;
        }

        [RelayCommand]
        private async Task GoTodoList()
        {
            await NavigationService.NavigateToToDoListAsync();
        }

        public IAsyncRelayCommand<BarcodeResult[]> OnDetectionFinishedCommand
        {
            get => this.onDetectionFinishedCommand;
        }

        private async Task HandleScanResultAsync(BarcodeResult[]? barcodeResults)
        {
            if (barcodeResults?.FirstOrDefault() is BarcodeResult barcodeResult)
            {
                // this.IsScannerPause = true;
                //
                // var stop = await this.dialogService.DisplayAlertAsync(
                //     "Barcode found",
                //     $"BarcodeType=\"{barcodeResult.BarcodeType}\"{Environment.NewLine}" +
                //     $"BarcodeFormat=\"{barcodeResult.BarcodeFormat}\"{Environment.NewLine}" +
                //     $"DisplayValue=\"{barcodeResult.DisplayValue}\"",
                //     "Stop", "Continue");
                //
                // if (stop)
                // {
                //     this.StopCamera();
                // }
                // else
                // {
                //     this.IsScannerPause = false;
                // }
            }

            await Task.CompletedTask;
        }
    }
}
