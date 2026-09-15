namespace MauiApp2.Views;

public partial class NiggerNum2 : ContentPage
{
	public NiggerNum2()
	{
		InitializeComponent();
	}
    private void Button_Click(object sender, EventArgs e)
    {
        string name = NameEntry.Text;

        if (int.TryParse(AgeEntry.Text, out int age))
        {
            int newAge = age + 10;
            ResultLabel.Text = $"{name} ,in ten years you will be {newAge}";

            candleHolder.Clear();
            // Create Candles
            for (int i = 0; i < newAge ; i++)
            {
                // create an Image obj with a candle
                Image candleImg = new Image() { Source = "candle.png", WidthRequest = 10};

                // add image to Stack candleHolder
                candleHolder.Children.Add(candleImg);
            }


        }
        else
        {
            ResultLabel.Text = "please enter an age thats in between 0 to 100";
        }
    }
}