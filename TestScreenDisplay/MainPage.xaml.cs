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
		lblScreenHeight.Text = $"{App.ScreenHeight}, {App.ScreenHeightDp}, {App.ScreenDensity}, SD: {App.ScaledDensity}";
		lblScreenWidth.Text = $"{App.ScreenWidth}, {App.ScreenWidthDp}, {App.ScreenDensity}, SD: {App.ScaledDensity}";
		Console.WriteLine($"H: {App.ScreenHeight} x W: {App.ScreenWidth}");
    }
}

