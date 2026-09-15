using Microsoft.Maui.Graphics.Text;

namespace MauiApp2.Views;

public partial class PageNumber3 : ContentPage
{
	public PageNumber3()
	{
		InitializeComponent();
	}
	private void ShowAge(object sender,EventArgs e)
	{
		CandelHolder.Children.Clear();
		var sliderAge = sender as Slider;
		int age = (int)sliderAge.Value;
		TextAge.Text = age.ToString();
		for (int i = 0; i < age; i++)
		{
			Image candleImg = new Image()
			{ Source = "candle.png", WidthRequest = 10, HeightRequest = 40 };
            CandelHolder.Children.Add(candleImg);
        }
		

	}
}