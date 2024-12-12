using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWToDoMobile.Models
{
    public partial class ListItem : ObservableObject
    {   
        public int Id { get; set; }

        [ObservableProperty]
        private string? description;

        [ObservableProperty]
        private bool isDone;
    }
}
