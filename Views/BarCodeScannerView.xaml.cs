namespace UWToDoMobile.Views;

public partial class BarCodeScannerView : ContentPage
{
    private readonly BarCodeScannerViewModel _viewModel;

    public BarCodeScannerView(BarCodeScannerViewModel viewModel)
	{
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}