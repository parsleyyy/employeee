namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new Phone
        {
            Title = "iPhone 7",
            Company = "Apple",
            Price = 52000
        };
    }

	
}

