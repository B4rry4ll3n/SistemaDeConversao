using Microsoft.Maui.Controls;

namespace DesignerMobile.Pages
{
    public partial class HectometrosParaMetros : ContentPage
    {
        public HectometrosParaMetros()
        {
            InitializeComponent();
        }

        private void OnConverterClicked(object sender, EventArgs e)
        {
            if (double.TryParse(entryHectometros.Text, out double hectometros))
            {
                double metros = hectometros * 100;
                labelResultado.Text = $"{hectometros} hm é igual a {metros} metros.";
            }
            else
            {
                labelResultado.Text = "Por favor, insira um valor válido.";
            }
        }
    }
}