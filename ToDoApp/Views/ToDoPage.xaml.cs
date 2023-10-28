using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public sealed partial class ToDoPage : Page
{
    public ToDoViewModel ViewModel
    {
        get;
    }

    public ToDoPage()
    {
        ViewModel = App.GetService<ToDoViewModel>();
        InitializeComponent();

        string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ToDo");
        string fileName = "ToDo.json";

        string filePath = Path.Combine(appDataFolder, fileName);

        try
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void AddTask_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        addTask();
        priorityMenu.Content = "Medium";
    }

    private void RemoveTask_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        removeTask();

    }

    private void MenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (sender is MenuFlyoutItem menuItem)
        {
            // Set the content of the DropDownButton to the selected item's text
            priorityMenu.Content = menuItem.Text;
        }
    }

    private void CheckBox_Ticked(object sender, RoutedEventArgs e)
    {
        
    }

    private void addTask()
    {
        var taskText = taskInput.Text;  
        string prio = (string)priorityMenu.Content;
        taskList.Items.Add(new TaskItem { IsCompleted= false, TaskName=taskText, priority= prio});
    }

    private void removeTask()
    {

    }

    private void refreshTasks()
    {

    }



    private void loadTasks()
    {

    }

    private void LoadTasksToListView()
    {

    }
}

public class TaskItem
{
    public required string TaskName
    {
        get; set;
    }

    public bool IsCompleted
    {
        get; set;
    }

    public required string priority
    {
        get; set; 
    }
}