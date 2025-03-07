namespace PrimeiroProjeto;

public partial class Positivo : ContentPage
{
	public Positivo()
	{
		InitializeComponent();
	}
    private async void NavigateTo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}