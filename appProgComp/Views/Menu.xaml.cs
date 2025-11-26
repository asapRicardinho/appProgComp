using System.Threading.Tasks;

namespace appProgComp.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
    }

    private async void btnComportamento_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new compEntrevista());
    }

    private async void btnCurriculo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new montarCurriculo());
    }

    private async void btnAutoconhecimento_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new autoConhecimento());
    }

    private async void btnRecursos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new recursos());
    }

    private async void btnAgradecimento_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new agradTela());
    }
}