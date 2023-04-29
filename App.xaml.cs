using CPAY.CPAY;

namespace CPAY;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new WelcomeScreen();
	}
}
