namespace PrimeiroProjeto;

public partial class Negativo : ContentPage
{
	public Negativo()
	{
		InitializeComponent();
	}
    private async void NavigateTo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}