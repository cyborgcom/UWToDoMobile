namespace UWToDoMobile.Views;

public partial class ToDoListView : ContentPage
{
    private readonly ToDoListViewModel _viewModel;

    public ToDoListView(ToDoListViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}