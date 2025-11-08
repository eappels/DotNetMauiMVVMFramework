using MVVMFrameworkDotNet9.ViewModels;

namespace MVVMFrameworkDotNet9.Views;

public partial class DemoView : ContentPage
{
	public DemoView(DemoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}