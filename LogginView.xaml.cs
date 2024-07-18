using System.Windows;
using System.Windows.Controls;

namespace WpfDemo;

public partial class LogginView : UserControl
{
    public LogginView()
    {
        InitializeComponent();
    }

    private void LoginButton_Clicked(object sender, RoutedEventArgs e)
    {
        Window window = Window.GetWindow(this);
        window.Content = new InvoiceView();
    }
}