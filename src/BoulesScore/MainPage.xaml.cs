namespace BoulesScore;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new BoulesScore.ViewModels.MainPage();
	}

}

