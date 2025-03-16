using Microsoft.Maui.Controls;

namespace DesignerMobile.Pages
{
    public partial class KilometrosParaMetros : ContentPage
    {
        public KilometrosParaMetros()
        {
            InitializeComponent();
        }

        private void OnConverterClicked(object sender, EventArgs e)
        {
            if (double.TryParse(entryKilometros.Text, out double kilometros))
            {
                double metros = kilometros * 1000;
                labelResultado.Text = $"{kilometros} km é igual a {metros} metros.";
            }
            else
            {
                labelResultado.Text = "Por favor, insira um valor válido.";
            }
        }
    }
}