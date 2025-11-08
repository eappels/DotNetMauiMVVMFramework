using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMFrameworkDotNet9.Interfaces;

namespace MVVMFrameworkDotNet9.ViewModels;

public partial class DemoViewModel : ObservableObject
{

    private readonly IDemoService demoService;

    public DemoViewModel(IDemoService demoService)
    {
        this.demoService = demoService;
        DemoString = "Click the button to call the demo service.";
    }

    [RelayCommand]
    public async Task TestMethod()
    {
        try
        {
            DemoString = string.Empty;
            IsBusy = true;
            DemoString = await demoService.DemoMethodAsync();
        }
        catch (Exception ex)
        {
            DemoString = $"Error: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    [ObservableProperty]
    public string demoString = string.Empty;

    [ObservableProperty]
    public bool isBusy;
}