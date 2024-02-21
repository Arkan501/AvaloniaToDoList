using System.Collections.Generic;

namespace Services;

public class ToDoListService
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Walk the dog" },
        new ToDoItem { Description = "Buy some milk" },
        new ToDoItem { Desription = "learn Avalonia", IsChecked = true }
    };
}