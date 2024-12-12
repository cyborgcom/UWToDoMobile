using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using UWToDoMobile.Models;

namespace UWToDoMobile.ViewModels
{
    /// <summary>
    /// View model for the To Do List page.
    /// </summary>
    public partial class ToDoListViewModel : ViewModelBase
    {
        #region Attributes

        private readonly IToDoListService ToDoListService;
        private readonly INavigationService NavigationService;
        private bool _isDataLoaded;


        #endregion

        #region Properties

        [ObservableProperty]
        private ObservableCollection<ListItem>? _uncompletedItems = new();

        [ObservableProperty]
        private ObservableCollection<ListItem>? _completedItems = new();

        [ObservableProperty]
        private ListItem? _selectedItem = new();

        #endregion


        #region Commands

        [RelayCommand]
        private async Task DragedItem(object item)
        {
            await LoadData();
        }

        [RelayCommand]
        private async Task DropItem(ListItem item)
        {
            item.IsDone = !item.IsDone;
            await ToDoListService.Upsert(item);
            await LoadData();
        }

        [RelayCommand]
        private async Task Appearing()
        {
            await LoadData();
        }

        [RelayCommand]
        private async Task Add()
        {
            var newItem = new ListItem();
            await ToDoListService.Upsert(newItem);
            await LoadData();
        }

        [RelayCommand]
        private async Task DeleteItem(ListItem item)
        {
            await ToDoListService.Delete(item.Id);
            await LoadData();
        }

        [RelayCommand]
        private async Task BarCodeReader()
        {
            await NavigationService.NavigateToBarCodeScannerAsync();
        }

        [RelayCommand]
        private async Task CheckedChanged(ListItem item)
        {
            if (item == null || (_isDataLoaded && ToDoListService == null))
            {
                return;
            }

            await ToDoListService.Upsert(item);
            await LoadData();
        }

        #endregion

        #region Initialization

        public ToDoListViewModel(IToDoListService toDoListService, INavigationService navigationService)
        {
            Title = "To Do List";

            ToDoListService = toDoListService;
            NavigationService = navigationService;
        }

        #endregion

        #region Public Methods

        public override async Task LoadData()
        {
            var items = await ToDoListService.GetItems();
            UncompletedItems = new ObservableCollection<ListItem>(items.Where(i => i != null && !i.IsDone));
            CompletedItems = new ObservableCollection<ListItem>(items.Where(i => i != null && i.IsDone));

            _isDataLoaded = true;
        }

        #endregion
    }
}
