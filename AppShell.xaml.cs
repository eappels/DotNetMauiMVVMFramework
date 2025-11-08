using MVVMFrameworkDotNet9.Views;

namespace MVVMFrameworkDotNet9;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Resolve DemoView from the DI container so its constructor param works
        var demoPage = App.Current.Services.GetRequiredService<DemoView>();

        Items.Add(new ShellContent
        {
            Title = "Demo",
            Content = demoPage,
            Route = "DemoView"
        });
    }
}