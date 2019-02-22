using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Zhenchak01.ViewModels;

namespace Zhenchak01
{
    public class BirthdayView : UserControl 
    {
        public BirthdayView()
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

