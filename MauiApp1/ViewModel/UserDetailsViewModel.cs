namespace MauiApp1.ViewModel;

[QueryProperty("User", "User")]
public partial class UserDetailsViewModel : BaseViewModel
{

    public UserDetailsViewModel(IMap map)
    {

    }

    [ObservableProperty]
    User user;

}
