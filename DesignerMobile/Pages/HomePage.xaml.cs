using Microsoft.Maui.Controls;

namespace DesignerMobile.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnKmToMtClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KilometrosParaMetros());
        }

        private async void OnMtToCmClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MetrosParaCentimetros());
        }

        private async void OnHecToMtClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HectometrosParaMetros());
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}