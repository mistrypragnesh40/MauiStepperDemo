namespace MauiStepperDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
	
	}

    private void btnVertical_Clicked(object sender, EventArgs e)
    {
		AppShell.Current.GoToAsync(nameof(VerticalStepperDemo));
    }

    private void btnHorizontal_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync(nameof(HorizontalStepperDemo));
    }
}

