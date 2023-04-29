namespace CPAY.CPAY;

public partial class LoginPage : ContentPage
{
    private int _loginAttempts = 0;
    public string Vusername = "Gbenga";
    public string Vpassword = "1234";

    public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Username and Password can't be empty", "OK");
        }

        // Add your login validation logic here
        else if (username == Vusername && password == Vpassword)
        {
            // Login successful
            await DisplayAlert("Successful", "Login Successful", "OK");
            // Navigate to the next page
            await Shell.Current.GoToAsync("///DashBoard");

        }
        else
        {
            _loginAttempts++;

            if (_loginAttempts >= 3)
            {
                // Disable the login button and show a message to the user
                LoginButton.IsEnabled = false;
                await DisplayAlert("Error", "You have exceeded the maximum number of login attempts.", "OK");
            }
            else
            {
                // Show an error message to the user
                await DisplayAlert("Error", "Invalid username or password. Please try again.", "OK");
            }
        }
    }

    private void OnClearButton_Clicked(object sender, EventArgs e)
    {
        PasswordEntry.Text = PasswordEntry.Text.Substring(0, PasswordEntry.Text.Length - 1);
    }

    private void OnNumberButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        PasswordEntry.Text += button.Text;
    }

    private async void exitapp_Clicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Confirm", "Are you sure you want to exit app?", "Yes", "No");
        if (answer)
        {
            // Perform the logout action
            // ...
            Application.Current.Quit();
        }
    }
}