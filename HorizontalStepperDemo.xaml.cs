namespace MauiStepperDemo;

public partial class HorizontalStepperDemo : ContentPage
{
	public HorizontalStepperDemo()
	{
		InitializeComponent();
	}

    private void stepperView_OnStepContinue(object sender, EventArgs e)
    {
        if (stepperView.Steps.Count > stepperView.CurrentStep)
            stepperView.CurrentStep += 1;
    }

    private void stepperView_OnStepCancel(object sender, EventArgs e)
    {
        if (stepperView.CurrentStep > 0)
            stepperView.CurrentStep -= 1;
    }
}