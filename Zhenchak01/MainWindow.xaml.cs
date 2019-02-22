using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Zhenchak01.ViewModels;

namespace Zhenchak01
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BirthdayViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}