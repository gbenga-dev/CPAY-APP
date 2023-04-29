using CPAY.Model;
namespace CPAY.CPAY;

public partial class DashBoard : ContentPage
{
    private CpayAccount account;

    private TransactionHistory history;
	public DashBoard()
	{
		InitializeComponent();
        account = new CpayAccount(10000);
        lblBalance.Text = account.Balance.ToString("C");
	}

    private async void LogOutbtn_Clicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Confirm", "Are you sure you want to log out?", "Yes", "No");
        if (answer)
        {
            // Perform the logout action
            // ...
            App.Current.MainPage = new AppShell();
        }
    }

    private async void CheckBalancebtn_Clicked(object sender, EventArgs e)
    {
        lblBalance.Text = account.Balance.ToString();
        await DisplayAlert("Account Balance", lblBalance.Text, "OK");
    }

    private async void Withdrawbtn_Clicked(object sender, EventArgs e)
    {
        string withdraw = await DisplayPromptAsync("Deposit", "Amount to be Withdrawn:", keyboard: Keyboard.Numeric);
        
        if (!string.IsNullOrEmpty(withdraw))
        {
            await DisplayAlert("Confirm", $"Are you sure you want to withdraw {withdraw}", "No", "Yes");
            decimal amount = Convert.ToDecimal(withdraw);
            account.Withdraw(amount);
            history.AmountWithdrawn += amount;
            history.TimeInitiated = DateTime.Now;
            lblBalance.Text = account.Balance.ToString("C");
            
        }
        else
        {
            await DisplayAlert("Error", "Enter amount to Withdraw", "OK");
        }
    }

    private async void Depositbtn_Clicked(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Deposit", "Amount to be Deposited:", keyboard: Keyboard.Numeric);
        
        if (!string.IsNullOrEmpty(result))
        {
            await DisplayAlert("Confirm", $"Are you sure you want to deposit {result}", "Yes", "No");
            decimal amount = Convert.ToDecimal(result);
            account.Deposit(amount);
            history.AmountDeposited += amount;
            history.TimeInitiated = DateTime.Now;
            lblBalance.Text = account.Balance.ToString("C");
        }
        else
        {
            await DisplayAlert("Error", "Enter amount to Deposit", "OK");
        }
    }
}