namespace MauiApp1.View;

public partial class MainPage : ContentPage
{
	public MainPage(UsersViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}

