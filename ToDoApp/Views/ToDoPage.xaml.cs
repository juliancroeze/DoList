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
    }

    private void RemoveTask_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        removeTask();

    }

    private void CheckBox_Ticked(object sender, RoutedEventArgs e)
    {
        
    }

    private void addTask()
    {
        var taskText = taskInput.Text;  
        taskList.Items.Add(new TaskItem { IsCompleted= false, TaskName=taskText});
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
}