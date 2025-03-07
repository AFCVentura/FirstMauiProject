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
       
    }

}