namespace TestScreenDisplay;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void ButtonCheckScreen_Clicked(object sender, EventArgs e)
    {
		lblScreenHeight.Text = $"{App.ScreenHeight}, {App.ScreenHeightDp}, {App.ScreenDensity}";
		lblScreenWidth.Text = $"{App.ScreenWidth}, {App.ScreenWidth}, {App.ScreenDensity}";
		Console.WriteLine($"H: {App.ScreenHeight} x W: {App.ScreenWidth}");
    }
}

