using Microsoft.Maui.Controls;

namespace DesignerMobile.Pages
{
    public partial class MetrosParaCentimetros : ContentPage
    {
        public MetrosParaCentimetros()
        {
            InitializeComponent();
        }

        private void OnConverterClicked(object sender, EventArgs e)
        {
            if (double.TryParse(entryMetros.Text, out double metros))
            {
                double centimetros = metros * 100;
                labelResultado.Text = $"{metros} m � igual a {centimetros} cm.";
            }
            else
            {
                labelResultado.Text = "Por favor, insira um valor v�lido.";
            }
        }
    }
}