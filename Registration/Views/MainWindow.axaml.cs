using System;
using Avalonia.Controls;
using Avalonia.Controls.Remote;
using Avalonia.Interactivity;
using DynamicData.Tests;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.VisualBasic.CompilerServices;
using Tmds.DBus.Protocol;

namespace Registration.Views
{
    public partial class MainWindow : Window
    {
        public string name { get; set; }
        public string pass { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        public void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            new Window2().Show();
            Close();
        }

        private void Button_OnClick2(object? sender, RoutedEventArgs e)
        {
            name = Name.Text;
            pass = password.Text;
            Window3 window3 = new Window3(name,pass);
            window3.Show();
        }
    }
}