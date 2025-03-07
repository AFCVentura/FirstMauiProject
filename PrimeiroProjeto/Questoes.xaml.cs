namespace PrimeiroProjeto;

public partial class Questoes : ContentPage
{
	public Questoes()
	{
		InitializeComponent();
	}

	private async void ClickedSim(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Positivo");
	}
    private async void ClickedNao(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Negativo");
    }
}