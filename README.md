# Plugin.Maui.Stepper
Plugin.Maui.Stepper - is a cross-platform plugin for .NET MAUI ,Used to display progress through a sequence of steps.


![ezgif com-video-to-gif](https://user-images.githubusercontent.com/47309472/221900017-4490f0cc-7bbd-4278-999c-b0b8adf3cb2f.gif)

## How To Use 
Available on NuGet: https://www.nuget.org/packages/Plugin.Maui.Stepper/1.0.3  

Install this Plugin in your .NET MAUI Project

Now add following namespace to your content page

```
xmlns:mauiStepper="clr-namespace:MauiStepper.Views;assembly=MauiStepper"
```

## Vertical Stepper View

```
<mauiStepper:VerticalStepperView x:Name="stepperView" OnStepTapped="stepperView_OnStepTapped"
                  OnStepContinue="stepperView_OnStepContinue" OnStepCancel="stepperView_OnStepCancel">
            <mauiStepper:VerticalStepperView.Steps>
                <mauiStepper:VerticalStepView Title="Step 1">
                    <mauiStepper:VerticalStepView.Content>
                        <VerticalStackLayout>
                            <Label Text="Description 1" />
                            <Label Text="Description 2" />
                            <Label Text="Description 3" />
                            <Label Text="Description 4" />
                            <Label Text="Description 5" />
                        </VerticalStackLayout>
                    </mauiStepper:VerticalStepView.Content>
                </mauiStepper:VerticalStepView>
                <mauiStepper:VerticalStepView Title="Step 2">
                    <mauiStepper:VerticalStepView.Content>
                        <VerticalStackLayout>
                            <Label Text="Description 1" />
                            <Label Text="Description 2" />
                            <Label Text="Description 3" />
                            <Label Text="Description 4" />
                            <Label Text="Description 5" />
                        </VerticalStackLayout>
                    </mauiStepper:VerticalStepView.Content>
                </mauiStepper:VerticalStepView>
                <mauiStepper:VerticalStepView Title="Step 3">
                    <mauiStepper:VerticalStepView.Content>
                        <VerticalStackLayout>
                            <Label Text="Description 1" />
                            <Label Text="Description 2" />
                            <Label Text="Description 3" />
                            <Label Text="Description 4" />
                            <Label Text="Description 5" />
                        </VerticalStackLayout>
                    </mauiStepper:VerticalStepView.Content>
                </mauiStepper:VerticalStepView>
            </mauiStepper:VerticalStepperView.Steps>
```

## Code Behind 

```
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
    
    private void stepperView_OnStepTapped(object sender, int e)
    {
        stepperView.CurrentStep = e;
    }
```

## Styles Property
```
StepTitleStyle : Used for setting title Label Style 
StepIndexStyle : Used for setting Index Count Label Style 
StepIndexHeightWidth: used for setting height & width request of step counter
ActiveStepIndexBackgroundColor: used for setting active step background color.
StepIndexBackgroundColor: used for setting non-active step background color.
ContinueButtonStyle: used for setting continue button style
CancelButtonStyle: used for setting cancel button style.
```

## How to Use Style Property
Define Style for label or Button in your content page or in styles.xaml file & use in vertical stepper view.
```
 <ContentPage.Resources>
        <ResourceDictionary>
            <Style TargetType="Button" x:Key="btnCancelStyle">
                <Setter Property="BackgroundColor" Value="Orange" />
            </Style>
        </ResourceDictionary>
    </ContentPage.Resources>

  <mauiStepper:VerticalStepperView x:Name="stepperView"  CancelButtonStyle="{x:StaticResource btnCancelStyle}">
```

