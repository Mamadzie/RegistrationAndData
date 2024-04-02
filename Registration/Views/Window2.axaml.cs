using System;
using System.Drawing.Printing;
using System.Net.Mime;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Registration.Views;

public partial class Window2 : Window 
{
    public Window2()
    {
        InitializeComponent();
        
        
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
    }
}