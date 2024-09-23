using System.Net.Http.Json;

namespace MauiApp1.Services;

public class UserService
{
    HttpClient httpClient;

    public UserService()
    {
        httpClient = new HttpClient();
    }

    List<User> userList = new ();

    public async Task<List<User>> GetUsers()
    {
        if (userList?.Count > 0)
            return userList;

        var url = "https://montemagno.com/monkeys.json";

        var response = await httpClient.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            userList = await response.Content.ReadFromJsonAsync<List<User>>();
        }

        return userList;
    }
}
