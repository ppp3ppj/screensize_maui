namespace TestScreenDisplay;

public partial class App : Application
{
    public static int ScreenHeight { get; set; }
    public static int ScreenWidth { get; set; }

	public static int ScreenHeightDp { get; set; }
	public static int ScreenWidthDp { get; set; }
	public static int ScreenDensity { get; set; }

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
