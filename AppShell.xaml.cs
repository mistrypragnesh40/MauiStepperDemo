namespace MauiStepperDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(VerticalStepperDemo), typeof(VerticalStepperDemo));
        Routing.RegisterRoute(nameof(HorizontalStepperDemo), typeof(HorizontalStepperDemo));

    }
}
