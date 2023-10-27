using Microsoft.UI.Xaml.Controls;

using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public sealed partial class TrashPage : Page
{
    public TrashViewModel ViewModel
    {
        get;
    }

    public TrashPage()
    {
        ViewModel = App.GetService<TrashViewModel>();
        InitializeComponent();
    }
}
