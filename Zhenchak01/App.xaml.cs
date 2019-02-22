using Avalonia;
using Avalonia.Markup.Xaml;

namespace Zhenchak01
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}