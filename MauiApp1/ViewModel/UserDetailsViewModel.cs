namespace MauiApp1.ViewModel;

[QueryProperty("User", "User")]
public partial class UserDetailsViewModel : BaseViewModel
{
    IMap map;
    public UserDetailsViewModel(IMap map)
    {
        this.map = map;
    }

    [ObservableProperty]
    User user;

    [RelayCommand]
    async Task OpenMapAsync()
    {
        try
        {
            await map.OpenAsync(User.Latitude, User.Longitude,
                new MapLaunchOptions
                {
                    Name = User.Name,
                    NavigationMode = NavigationMode.None
                });
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",
                $"Unable to open map: {ex.Message}", "OK");
        }

        //[RelayCommand]
        //async Task GoTaskAsync()
        //{
        //    await Shell.Current.GoToAsync("..=id=1");
        //}
    }
}
