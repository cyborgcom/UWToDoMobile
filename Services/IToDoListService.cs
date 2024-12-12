using UWToDoMobile.Models;

namespace UWToDoMobile.Services
{
    public interface IToDoListService
    {
        Task Upsert(ListItem listItem);
        Task Delete(int id);
        Task<IEnumerable<ListItem>> GetItems();
    }
}