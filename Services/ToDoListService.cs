using UWToDoMobile.Models;

namespace UWToDoMobile.Services
{
    /// <summary>
    /// ToDoListService with initial mocked data
    /// </summary>
    public class ToDoListService : IToDoListService
    {
        /// <summary>
        /// 
        /// </summary>
        public ToDoListService()
        {
            listItems.Add(new ListItem { Id = 1, Description = "Buy milk", IsDone = false });
            listItems.Add(new ListItem { Id = 2, Description = "Call mom", IsDone = false });
            listItems.Add(new ListItem { Id = 3, Description = "Finish homework", IsDone = false });
            listItems.Add(new ListItem { Id = 4, Description = "Finish Task", IsDone = true });
        }

        private List<ListItem> listItems = new List<ListItem>();

        /// <summary>
        /// Inserts or updates an item in the list
        /// </summary>
        /// <param name="listItem"></param>
        /// <returns></returns>
        public async Task Upsert(ListItem listItem)
        {
            await Task.Run(() =>
            {
                if (listItem.Id == 0)
                {
                    listItem.Id = listItems.Count + 1;
                    listItems.Add(listItem);
                }
                else
                {
                    var existingItem = listItems.FirstOrDefault(i => i.Id == listItem.Id);
                    if (existingItem != null)
                    {
                        existingItem.Description = listItem.Description;
                        existingItem.IsDone = listItem.IsDone;
                    }
                }
            });
        }



        /// <summary>
        /// Deletes an item from the list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            await Task.Run(() =>
            {
                var existingItem = listItems.FirstOrDefault(i => i.Id == id);
                if (existingItem != null)
                {
                    listItems.Remove(existingItem);
                }
            });
        }

        /// <summary>
        /// Returns the list of items
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ListItem>> GetItems()
        {
            //To follow async pattern, we need to return a Task object
            return await Task.Run(() => listItems);
        }



    }
}
