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
            ResultLabel.Text =
                $"{name} ,in ten years you will be {newAge}";
        }
        else
        {
            ResultLabel.Text = "please enter an age thats in between 0 to 100";
        }
    }
}