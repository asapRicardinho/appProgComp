using appProgComp.Views;

namespace appProgComp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnAcessar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }
    }
}
