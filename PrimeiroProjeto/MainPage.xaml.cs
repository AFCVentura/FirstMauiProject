using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateTo(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Questoes");
        }

        private async void ShowAlert(object sender, EventArgs e)
        {
            bool resposta = await DisplayAlert("Continuar", "Gostaria de continuar", "Sim", "Não");
        }

        private async void ShowAlertWithOptions(object sender, EventArgs e)
        {
            string resposta = await DisplayActionSheet("Enviar para:", "Cancelar", "Deletar", "Facebook", "Twitter", "Instagram");
        }

        private async void ShowPrompt(object sender, EventArgs e)
        {
            string resposta = await DisplayPromptAsync("Opinião", "Diga sua opinião");
        }

    }

}