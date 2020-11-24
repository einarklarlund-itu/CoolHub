using CoolHub.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace CoolHub.ViewModels
{
    public interface IToDoViewModel
    {
        bool IsBusy { get; set; }
        int ItemsToDo { get; }
        ToDoItem ToDoItem { get; set; }
        List<ToDoItem> ToDoItemList { get; }

        event PropertyChangedEventHandler PropertyChanged;

        void SaveToDoItem(ToDoItem todoitem);
    }    
}