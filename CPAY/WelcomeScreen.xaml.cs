namespace CPAY.CPAY;

public partial class WelcomeScreen : ContentPage
{
	public WelcomeScreen()
	{
		InitializeComponent();
	}

    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }
}