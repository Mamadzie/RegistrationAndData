using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Remote;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using HarfBuzzSharp;

namespace Registration.Views;

public partial class Window3 : Window
{
    
    
    public Window3(string name, string pass)
    {
        InitializeComponent();
        Your_name.Text = name;
        Your_pass.Text = pass;
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
    }
    
}