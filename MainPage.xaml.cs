using Microsoft.Maui.Platform;

namespace Leben;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		Offset = 0.1;
	}

	public static readonly BindableProperty OffsetProperty = BindableProperty.Create("Offset", typeof(double), typeof(double), 0.1);
	public double Offset
	{
		get => (double)GetValue(OffsetProperty); 
		set => SetValue(OffsetProperty, value);
	}


    private void ClickGestureRecognizer_Clicked(object sender, TappedEventArgs e)
    {
		Frame quadro = (Frame)sender;

		quadro.Animate("MudaFundo", new Animation(v => ((LinearGradientBrush)quadro.Background).GradientStops[0].Offset = (float)v, 0, 1, Easing.Default), 8, 4000, Easing.Linear, null, () => true);
    }
}

