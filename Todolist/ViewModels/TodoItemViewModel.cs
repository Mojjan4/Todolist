using System;
using Todolist.Models;
using Xamarin.Forms;
using System.Windows.Input;

namespace Todolist.ViewModels
{
    public class TodoItemViewModel : ViewModel
    {
        public ICommand ToggleCompleted => new Command((arg) =>
        {
            Item.Completed = !Item.Completed;
            ItemStatusChanged?.Invoke(this, new EventArgs());
        });

        public TodoItemViewModel(TodoItem item) => Item = item;

        public event EventHandler ItemStatusChanged;
        public TodoItem Item { get; private set; }
        public string StatusText => Item.Completed ? "Reactivate" : "Completed";
    }
}