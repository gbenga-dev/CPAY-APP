using CPAY.CPAY;
namespace CPAY;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(DashBoard), typeof(DashBoard));
        Routing.RegisterRoute(nameof(DepositPage), typeof(DepositPage));
        Routing.RegisterRoute(nameof(WithdrawPage), typeof(WithdrawPage));
    }
}
